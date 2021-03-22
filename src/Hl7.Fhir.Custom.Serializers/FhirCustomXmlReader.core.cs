using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Threading;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.CustomSerializer
{
    public class FhirCustomXmlSerializationReader : XmlSerializationReader
    {
        public Resource Parse()
        {
            var reader = new FhirCustomXmlReader();
            return reader.Parse(this.Reader, new OperationOutcome(), null);
        }

        protected override void InitCallbacks()
        {
        }

        protected override void InitIDs()
        {
        }
    }

    public partial class FhirCustomXmlReader
    {
        public bool ShouldSkipNodeType(XmlNodeType nodeType)
        {
            return nodeType == XmlNodeType.Comment
                || nodeType == XmlNodeType.XmlDeclaration
                || nodeType == XmlNodeType.Whitespace
                || nodeType == XmlNodeType.SignificantWhitespace
                || nodeType == XmlNodeType.CDATA
                || nodeType == XmlNodeType.Notation
                || nodeType == XmlNodeType.ProcessingInstruction;
        }

        private static void HandlePropertyNotFound(XmlReader reader, OperationOutcome outcome, string locationPath)
        {
            // report the issue
            IXmlLineInfo info = reader as IXmlLineInfo;
            var locations = new List<string>();
            locations.Add(locationPath);
            locations.Add($"xml position: {info.LineNumber},{info.LinePosition}");

            var issue = new OperationOutcome.IssueComponent()
            {
                Severity = OperationOutcome.IssueSeverity.Error,
                Code = OperationOutcome.IssueType.Structure,
                Details = new CodeableConcept() { Text = $"Unexpected element found {reader.Name}" },
                Location = locations
            };
            outcome.Issue.Add(issue);

            // Scan over the erroneous property
            if (!reader.IsEmptyElement)
            {
                var readerChild = reader.ReadSubtree();
                if (readerChild.Read())
                {
                    issue.Diagnostics = readerChild.ReadOuterXml();
                }
                readerChild.Close();
                info = reader as IXmlLineInfo;
                locations[1] += $" to {info.LineNumber},{info.LinePosition}";
                issue.Location = locations;
            }
        }

        private static async Task HandlePropertyNotFoundAsync(XmlReader reader, OperationOutcome outcome, string locationPath)
        {
            // report the issue
            IXmlLineInfo info = reader as IXmlLineInfo;
            var locations = new List<string>();
            locations.Add(locationPath);
            locations.Add($"xml position: {info.LineNumber},{info.LinePosition}");

            var issue = new OperationOutcome.IssueComponent()
            {
                Severity = OperationOutcome.IssueSeverity.Error,
                Code = OperationOutcome.IssueType.Structure,
                Details = new CodeableConcept() { Text = $"Unexpected element found {reader.Name}" },
                Location = locations
            };
            outcome.Issue.Add(issue);

            // Scan over the erroneous property
            if (!reader.IsEmptyElement)
            {
                using (var readerChild = reader.ReadSubtree())
                {
                    if (await readerChild.ReadAsync().ConfigureAwait(false))
                    {
                        issue.Diagnostics = await readerChild.ReadOuterXmlAsync().ConfigureAwait(false);
                    }
                    readerChild.Close();
                }
                info = reader as IXmlLineInfo;
                locations[1] += $" to {info.LineNumber},{info.LinePosition}";
                issue.Location = locations;
            }
        }

        private static void HandleAttributeNotFound(XmlReader reader, OperationOutcome outcome, string locationPath)
        {
            IXmlLineInfo info = reader as IXmlLineInfo;
            outcome.Issue.Add(new OperationOutcome.IssueComponent()
            {
                Severity = OperationOutcome.IssueSeverity.Error,
                Code = OperationOutcome.IssueType.Structure,
                Details = new CodeableConcept() { Text = $"Unexpected attribute found {reader.Name}" },
                Location = new string[] { locationPath, $"xml position: {info.LineNumber},{info.LinePosition}" }
            });
        }

        private static void HandleAttributeInvalidValue(XmlReader reader, string dataFormatType, OperationOutcome outcome, string locationPath, Exception ex)
        {
            IXmlLineInfo info = reader as IXmlLineInfo;
            outcome.Issue.Add(new OperationOutcome.IssueComponent()
            {
                Severity = OperationOutcome.IssueSeverity.Error,
                Code = OperationOutcome.IssueType.Value,
                Details = new CodeableConcept() { Text = $"Invalid {dataFormatType} value '{reader.Value}'" },
                Location = new string[] { locationPath, $"xml position: {info.LineNumber},{info.LinePosition}" },
                Diagnostics = ex.Message
            });
        }

        public void Parse<T>(Code<T> result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
            where T : struct
        {
            // skip ignored elements
            while (ShouldSkipNodeType(reader.NodeType))
                if (!reader.Read())
                    return;

            if (reader.MoveToFirstAttribute())
            {
                do
                {
                    switch (reader.Name)
                    {
                        case "id":
                            result.ElementId = reader.Value;
                            break;
                        case "value":
                            // Should this be validated?
                            result.ObjectValue = reader.Value;
                            break;
                        default:
                            // Property not found
                            HandleAttributeNotFound(reader, outcome, locationPath);
                            break;
                    }
                } while (reader.MoveToNextAttribute());
                reader.MoveToElement();
            }
            if (reader.IsEmptyElement)
            {
                // contextLocation.Pop();
                return;
            }
            // otherwise proceed to read all the other nodes
            while (reader.Read())
            {
                if (cancellationToken.IsCancellationRequested)
                    return;
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "extension":
                            var newItem_extension = new Hl7.Fhir.Model.Extension();
                            Parse(newItem_extension, reader, outcome, locationPath + ".extension[" + result.Extension.Count + "]", cancellationToken); // 20
                            result.Extension.Add(newItem_extension);
                            break;
                        default:
                            // Property not found, skip over it
                            HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
                            break;
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
                {
                    break;
                }
            }
        }

        public async Task ParseAsync<T>(Code<T> result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
            where T : struct
        {
            // skip ignored elements
            while (ShouldSkipNodeType(reader.NodeType))
                if (!await reader.ReadAsync().ConfigureAwait(false))
                    return;

            if (reader.MoveToFirstAttribute())
            {
                do
                {
                    switch (reader.Name)
                    {
                        case "id":
                            result.ElementId = reader.Value;
                            break;
                        case "value":
                            // Should this be validated?
                            result.ObjectValue = reader.Value;
                            break;
                        default:
                            // Property not found
                            HandleAttributeNotFound(reader, outcome, locationPath);
                            break;
                    }
                } while (reader.MoveToNextAttribute());
                reader.MoveToElement();
            }
            if (reader.IsEmptyElement)
            {
                // contextLocation.Pop();
                return;
            }
            // otherwise proceed to read all the other nodes
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                if (cancellationToken.IsCancellationRequested)
                    return;
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "extension":
                            var newItem_extension = new Hl7.Fhir.Model.Extension();
                            await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension[" + result.Extension.Count + "]", cancellationToken); // 20
                            result.Extension.Add(newItem_extension);
                            break;
                        default:
                            // Property not found, skip over it
                            HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
                            break;
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
                {
                    break;
                }
            }
        }
    }
}
