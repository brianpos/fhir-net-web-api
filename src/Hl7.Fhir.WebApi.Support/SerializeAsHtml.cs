using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hl7.Fhir.WebApi
{
    /// <summary>
    /// Simple Formatting class to output a FHIR resource for HTML display (as either XML or JSON)
    /// (will make references clickable)
    /// </summary>
    public static class SerializeAsHtml
    {
        public static string ToHtmlXml(this Hl7.Fhir.Model.Resource me, CancellationToken ct, string baseUrl, SummaryType st)
        {
            var ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);
            WriteHtmlXml(me, sw, ct, baseUrl, st);
            sw.Flush();
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            return sr.ReadToEnd();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="me"></param>
        /// <param name="sw"></param>
        /// <param name="ct"></param>
        /// <param name="baseUrl">Must end with the / (or be empty)</param>
        public static void WriteHtmlXml(this Hl7.Fhir.Model.Resource me, StreamWriter sw, CancellationToken ct, string baseUrl, SummaryType st)
        {
            // Before we actually do any serialization, apply the Summary Type property
            // (since this code doesn't handle this itself - yet)
            var partialResource = new Hl7.Fhir.Serialization.FhirXmlSerializer().SerializeToString(me, st);
            var resource = new Hl7.Fhir.Serialization.FhirXmlParser().Parse<Resource>(partialResource);

            sw.WriteLine("<div class='fhir_resource'>");
            sw.WriteLine($"&lt;{resource.TypeName} xmlns=\"http://hl7.org/fhir\"&gt;<br/>");
            WriteXmlChildProperties(resource.GetType(), resource.NamedChildren, 2, sw, ct, baseUrl, st);
            sw.WriteLine($"&lt;/{resource.TypeName}&gt;");
            sw.WriteLine("</div>");
        }

        public static string AppendSummaryFormat(string url, SummaryType st)
        {
            if (st == SummaryType.False) return url;
            if (url.Contains("?")) return url + "&_summary=" + st.GetLiteral();
            return url + "?_summary=" + st.GetLiteral();
        }

        private static void WriteXmlChildProperties(Type parent, IEnumerable<Model.ElementValue> namedChildren, int leadingTabs, StreamWriter sw, CancellationToken ct, string baseUrl, SummaryType st, bool linkToReference = false)
        {
            Introspection.ClassMapping.TryGetMappingForType(parent, Specification.FhirRelease.R4, out var mapping);
            foreach (var prop in namedChildren)
            {
                if (ct.IsCancellationRequested) break;
                var pi = mapping?.FindMappedElementByName(prop.ElementName);
                if (pi?.SerializationHint == Specification.XmlRepresentation.XmlAttr)
                    continue;
                if (prop.Value != null)
                {
                    if (prop.Value is Narrative)
                    {
                        sw.Write(new String(' ', leadingTabs));
                        sw.WriteLine($"&lt;!-- Narrative omitted --&gt;<br/>");
                        continue; // skip emitting the Narrative
                    }

                    sw.Write(new String(' ', leadingTabs));

                    // Write the element start text
                    sw.Write($"&lt;{prop.ElementName}");

                    // check for any attributes
                    if (prop.Value?.NamedChildren?.Any() == true)
                    {
                        if (Introspection.ClassMapping.TryGetMappingForType(prop.Value.GetType(), Specification.FhirRelease.R4, out var mappingChild))
                        {
                            foreach (var ca in prop.Value?.NamedChildren)
                            {
                                var piChild = mappingChild?.FindMappedElementByName(ca.ElementName);
                                if (piChild?.SerializationHint != Specification.XmlRepresentation.XmlAttr)
                                    continue;
                                // serialize this attr into the content
                                sw.Write($" {ca.ElementName}=\"{ca.Value}\"");
                            }
                        }
                    }


                    bool linkToChildReference = false;
                    if (prop.Value is ResourceReference resRef)
                    {
                        sw.WriteLine($"&gt;<br/>");
                        if (resRef.Reference != null)
                            linkToChildReference = true;
                    }
                    else if (prop.Value is Canonical can)
                    {
                        // Use a Resource Resolver here to locate the actual ID?
                        if (!string.IsNullOrEmpty(can.Value))
                        {
                            // Double encoding is required as we're pushing the XML to be displayed as HTML
                            var valStr = System.Net.WebUtility.HtmlEncode(System.Net.WebUtility.HtmlEncode(can.Value));
                            if (valStr.StartsWith("#"))
                                sw.Write($" value=\"<span class='canonical'><a href=\"{AppendSummaryFormat(can.Value, st)}\">{valStr}</a></span>\"");
                            else if (parent.Name == "QuestionnaireResponse" && prop.ElementName == "questionnaire")
                            {
                                // expand the canonical
                                var canonicalVersionLess = can.Value;
                                string version = null;
                                var verLoc = canonicalVersionLess.IndexOf("|");
                                if (verLoc > 0)
                                {
                                    version = canonicalVersionLess.Substring(verLoc + 1);
                                    canonicalVersionLess = canonicalVersionLess.Substring(0, verLoc);
                                }
                                sw.Write($" value=\"<span class='canonical'><a href=\"{baseUrl}Questionnaire?url={canonicalVersionLess}\">{AppendSummaryFormat(valStr, st)}</a></span>\"");
                            }
                            else
                                sw.Write($" value=\"<span class='canonical'>{AppendSummaryFormat(valStr, st)}</span>\"");
                        }
                        if (prop.Value?.NamedChildren?.Any() != true)
                            sw.WriteLine($"/&gt;<br/>");
                        else
                            sw.WriteLine($"&gt;<br/>");
                    }
                    else
                    {
                        if (prop.Value is PrimitiveType pt)
                        {
                            string valStr = PrimitiveTypeConverter.ConvertTo(pt.ObjectValue, typeof(string)) as string;
                            if (pt is FhirString fs || pt is Markdown)
                            {
                                // Double encoding is required as we're pushing the XML to be displayed as HTML
                                valStr = System.Net.WebUtility.HtmlEncode(System.Net.WebUtility.HtmlEncode(valStr));
                            }
                            if (prop.ElementName == "fullUrl" && prop.Value is FhirUri fi && (fi.Value.StartsWith(baseUrl)))
                            {
                                // The bundle URL link
                                sw.Write($" value=\"<span class='reference'><a href=\"{AppendSummaryFormat(valStr, st)}\">{valStr}</a></span>\"");
                            }
                            else if (prop.ElementName == "url" && prop.Value is FhirUri fi2 && (fi2.Value.StartsWith(baseUrl)))
                            {
                                // The bundle URL link
                                sw.Write($" value=\"<span class='reference'><a href=\"{AppendSummaryFormat(valStr, st)}\">{valStr}</a></span>\"");
                            }
                            else if (linkToReference && prop.ElementName == "reference")
                            {
                                if (valStr.StartsWith("http"))
                                    sw.Write($" value=\"<span class='reference'><a href=\"{valStr}\">{AppendSummaryFormat(valStr, st)}</a></span>\"");
                                else if (valStr.StartsWith("#"))
                                    sw.Write($" value=\"<span class='reference'><a href=\"{valStr}\">{AppendSummaryFormat(valStr, st)}</a></span>\"");
                                else
                                    sw.Write($" value=\"<span class='reference'><a href=\"{baseUrl}{valStr}\">{AppendSummaryFormat(valStr, st)}</a></span>\"");
                            }
                            else
                            {
                                if (pi?.SerializationHint != Specification.XmlRepresentation.XmlAttr)
                                    sw.Write($" value=\"{valStr}\"");
                            }
                            if (prop.Value?.NamedChildren?.Any() != true)
                                sw.WriteLine($" /&gt;<br/>");
                            else
                                sw.WriteLine($"&gt;<br/>");
                        }
                        else if (prop.Value is Attachment att)
                        {
                            if (prop.Value?.NamedChildren?.Any() == true)
                            {
                                sw.WriteLine($"&gt;<br/>");
                                if (att.Data != null)
                                {
                                    sw.Write(new String(' ', leadingTabs));
                                    sw.WriteLine($"<img alt=\"Photo Attachment\" with=\"200\" src=\"data:{att.ContentType};base64,{att.DataElement.ToString()}\" />");
                                }
                            }
                            // < SPAN class="t"> value</SPAN><SPAN class="m">="</SPAN><img alt="Photo Attachment" width="200"><xsl:attribute name="src"><xsl:text>data:image/jpeg;base64,</xsl:text><xsl:value-of select="."/></xsl:attribute></img><SPAN class="m">"</SPAN>

                        }
                        else
                        {
                            // This is a complex type
                            if (prop.Value?.NamedChildren?.Any() == true)
                            {
                                sw.WriteLine($"&gt;<br/>");
                            }
                        }
                    }
                    if (prop.Value?.NamedChildren?.Any() == true)
                    {
                        if (prop.Value is Resource resource)
                        {
                            leadingTabs += 2;
                            sw.Write(new String(' ', leadingTabs));
                            if (!string.IsNullOrEmpty(resource.Id))
                                sw.Write($"<span class=\"{prop.ElementName}\" id=\"{resource.Id}\">");
                            sw.WriteLine($"&lt;{resource.TypeName}&gt;<br/>");
                        }
                        WriteXmlChildProperties(prop.Value.GetType(), prop.Value.NamedChildren, leadingTabs + 2, sw, ct, baseUrl, st, linkToChildReference);
                        if (prop.Value is Resource resourceEnd)
                        {
                            sw.Write(new String(' ', leadingTabs));
                            sw.WriteLine($"&lt;/{resourceEnd.TypeName}&gt;<br/>");
                            if (!string.IsNullOrEmpty(resourceEnd.Id))
                                sw.WriteLine("</span>");
                            leadingTabs -= 2;
                        }
                        sw.Write(new String(' ', leadingTabs));
                        sw.WriteLine($"&lt;/{prop.ElementName}&gt;<br/>");
                    }
                }
            }
        }
    }
}
