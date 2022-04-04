using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
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
        public static string ToHtmlXml(this Hl7.Fhir.Model.Resource me, CancellationToken ct, string baseUrl)
        {
            var ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);
            WriteHtmlXml(me, sw, ct, baseUrl);
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
        public static void WriteHtmlXml(this Hl7.Fhir.Model.Resource me, StreamWriter sw, CancellationToken ct, string baseUrl)
        {
            sw.WriteLine("<div class='fhir_resource'>");
            sw.WriteLine($"&lt;{me.TypeName} xmlns=\"http://hl7.org/fhir\"&gt;<br/>");
            WriteChildProperties(me.NamedChildren, 2, sw, ct, baseUrl);
            sw.WriteLine($"&lt;/{me.TypeName}&gt;");
            sw.WriteLine("</div>");
        }

        private static void WriteChildProperties(IEnumerable<Model.ElementValue> namedChildren, int leadingTabs, StreamWriter sw, CancellationToken ct, string baseUrl, bool linkToReference = false)
        {
            foreach (var prop in namedChildren)
            {
                if (ct.IsCancellationRequested) break;
                if (prop.Value != null)
                {
                    if (prop.Value is Narrative)
                    {
                        sw.Write(new String(' ', leadingTabs));
                        sw.WriteLine($"&lt;!-- Narrative omitted --&gt;<br/>");
                        continue; // skip emitting the Narrative
                    }

                    sw.Write(new String(' ', leadingTabs));
                    bool linkToChildReference = false;
                    if (prop.Value is ResourceReference resRef)
                    {
                        sw.WriteLine($"&lt;{prop.ElementName}&gt;<br/>");
                        if (resRef.Reference != null)
                            linkToChildReference = true;
                    }
                    else if (prop.Value is Canonical can)
                    {
                        // Use a Resource Resolver here to locate the actual ID?
                        sw.Write($"&lt;{prop.ElementName}");
                        if (!string.IsNullOrEmpty(can.Value))
                        {
                            // Double encoding is required as we're pushing the XML to be displayed as HTML
                            var valStr = System.Net.WebUtility.HtmlEncode(System.Net.WebUtility.HtmlEncode(can.Value));
                            if (valStr.StartsWith("#"))
                                sw.Write($" value=\"<span class='canonical'><a href=\"{can.Value}\">{valStr}</a></span>\"");
                            else
                                sw.Write($" value=\"<span class='canonical'>{valStr}</span>\"");
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
                            if (linkToReference && prop.ElementName == "reference")
                            {
                                sw.Write($"&lt;{prop.ElementName} value=\"<span class='reference'><a href=\"{(valStr.StartsWith("#") ? "" : baseUrl)}{valStr}\">{valStr}</a></reference>\"");
                            }
                            else
                            {
                                sw.Write($"&lt;{prop.ElementName} value=\"{valStr}\"");
                            }
                            if (prop.Value?.NamedChildren?.Any() != true)
                                sw.WriteLine($" /&gt;<br/>");
                            else
                                sw.WriteLine($"&gt;<br/>");
                        }
                        else
                        {
                            // This is a complex type
                            if (prop.Value?.NamedChildren?.Any() == true)
                            {
                                sw.WriteLine($"&lt;{prop.ElementName}&gt;<br/>");
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
                        WriteChildProperties(prop.Value.NamedChildren, leadingTabs + 2, sw, ct, baseUrl, linkToChildReference);
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
