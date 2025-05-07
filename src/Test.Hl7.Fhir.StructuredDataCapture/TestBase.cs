using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace Hl7.Fhir.StructuredDataCapture.Test
{
	public class TestBase
	{
		public static void DebugDumpXml(Base item, [CallerMemberName] string methodName = null, [CallerArgumentExpression(nameof(item))] string argName = null)
		{
			if (item == null)
				Trace.WriteLine("(null)");
			else
			{
				var content = new FhirXmlSerializer(new SerializerSettings() { Pretty = true }).SerializeToString(item);
				Trace.WriteLine(content);

				if (methodName.StartsWith("ValidateQr"))
				{
					var hl7TestProjectDirectory = @"C:\git\hl7\fhir-test-cases\validator\questionnaire\brianpos";
					var hl7TestProjectOutputDirectory = @"C:\git\hl7\fhir-test-cases\validator\outcomes\brianpos";
					if (!Directory.Exists(hl7TestProjectDirectory))
						Directory.CreateDirectory(hl7TestProjectDirectory);

					if (argName == "q" || argName == "qr")
					{
						// Write this specific sample into a sample test file
						var contentJson = new FhirJsonSerializer(new SerializerSettings() { Pretty = true }).SerializeToString(item);
						var jsonFileName = KebabCaseFromPascalCaseInLowercase(methodName.Replace("ValidateQr", ""));
						System.IO.File.WriteAllText(Path.Combine(hl7TestProjectDirectory, $"{jsonFileName}-{argName}.json"), contentJson);
					}

					if (argName == "outcome")
					{
						// Update the manifest for this
						var contentJson = new FhirJsonSerializer(new SerializerSettings() { Pretty = true }).SerializeToString(item);
						var jsonFileName = KebabCaseFromPascalCaseInLowercase(methodName.Replace("ValidateQr", ""));
						var outcome = item as OperationOutcome;
						System.IO.File.WriteAllText(Path.Combine(hl7TestProjectOutputDirectory, $"R4.{jsonFileName}-qr-base.json"), contentJson);

						StringBuilder manifestSnippit = new StringBuilder();
						manifestSnippit.AppendLine($"    {{");
						manifestSnippit.AppendLine($"      \"name\": \"{jsonFileName}-qr\",");
						manifestSnippit.AppendLine($"      \"file\": \"questionnaire/brianpos/{jsonFileName}-qr.json\",");
						manifestSnippit.AppendLine($"      \"description\": \"Verify {jsonFileName}-qr against {jsonFileName}-q, expecting success: {outcome.Success}\",");
						manifestSnippit.AppendLine($"      \"fetcher\": \"standalone\",");
						manifestSnippit.AppendLine($"      \"version\": \"4.0\",");
						if (File.Exists(Path.Combine(hl7TestProjectDirectory, $"{jsonFileName}-q.json")))
						{
							manifestSnippit.AppendLine($"      \"supporting\": [");
							manifestSnippit.AppendLine($"        \"questionnaire/brianpos/{jsonFileName}-q.json\"");
							manifestSnippit.AppendLine($"      ],");
						}
						manifestSnippit.AppendLine($"      \"dotnet-brianpos\": {{");
						manifestSnippit.AppendLine($"        \"fatalCount\": {outcome.Fatals},");
						manifestSnippit.AppendLine($"        \"errorCount\": {outcome.Errors},");
						manifestSnippit.AppendLine($"        \"warningCount\": {outcome.Warnings},");
						// manifestSnippit.AppendLine($"        \"result\": \"outcomes/brianpos/R4.{jsonFileName}-qr-base.json\",");
						// manifestSnippit.AppendLine($"        \"outcome\": {outcome.ToJson(new FhirJsonSerializationSettings() { Pretty = true }).Replace("\n", "\n        ")}");
						manifestSnippit.AppendLine($"      }},");
						manifestSnippit.AppendLine($"      \"module\": \"questionnaire\"");
						manifestSnippit.AppendLine($"    }}");

						System.Console.Error.WriteLine(manifestSnippit);
						// File.AppendAllText(Path.Combine(hl7TestProjectDirectory, $"manifest.json"), manifestSnippit.ToString());

						// Now that we have our json snippit, lets:
						// * load the manifest file
						// * check that this test is not already in there (by existence of path `/test-cases[name='test'])
						// * update that entry if it exists
						// * if it doesn't exist, add it to the end of the json file
						// * save the file

						var rawJsonManifest = System.IO.File.ReadAllText(Path.Combine(hl7TestProjectDirectory, "manifest.json"));
						var manifest = Newtonsoft.Json.Linq.JObject.Parse(rawJsonManifest);
						var testCases = manifest["test-cases"] as Newtonsoft.Json.Linq.JArray;
						var testCase = testCases.FirstOrDefault(tc => tc["name"].ToString() == $"{jsonFileName}-qr");
						if (testCase != null)
						{
							// Update the test case
							testCase["dotnet-brianpos"]["fatalCount"] = outcome.Fatals;
							testCase["dotnet-brianpos"]["errorCount"] = outcome.Errors;
							testCase["dotnet-brianpos"]["warningCount"] = outcome.Warnings;
							// testCase["dotnet-brianpos"]["outcome"] = Newtonsoft.Json.Linq.JToken.Parse(outcome.ToJson(new FhirJsonSerializationSettings() { Pretty = true }));
							// Delete the outcome node if it exists
							if (testCase["dotnet-brianpos"]["outcome"] != null)
								testCase["dotnet-brianpos"]["outcome"].Parent.Remove();
							// testCase["dotnet-brianpos"]["result"] = $"outcomes/brianpos/R4.{jsonFileName}-qr-base.json";
							if (testCase["dotnet-brianpos"]["result"] != null)
								testCase["dotnet-brianpos"]["result"].Parent.Remove();
						}
						else
						{
							// Add the test case
							// testCases.Add(Newtonsoft.Json.Linq.JObject.Parse(manifestSnippit.ToString()));

							// don't just append the test case, insert it alphabetically by name
							var newTestCase = Newtonsoft.Json.Linq.JObject.Parse(manifestSnippit.ToString());
							int? index = null;
							var newNameToInsert = newTestCase["name"].ToString();
							for (int i = 0; i < testCases.Count; i++)
							{
								var name = testCases[i]["name"].ToString();
								if (string.Compare(name, newNameToInsert, StringComparison.OrdinalIgnoreCase) > 0)
								{
									index = i;
									break;
								}
							}
							if (index.HasValue)
								testCases.Insert(index.Value, newTestCase);
							else
								testCases.Add(newTestCase);
						}

						// Save the file
						System.IO.File.WriteAllText(Path.Combine(hl7TestProjectDirectory, "manifest.json"), manifest.ToString());
					}
				}
			}
		}

		private static string KebabCaseFromPascalCaseInLowercase(string input)
		{
			if (string.IsNullOrEmpty(input))
				return input;
			var result = Regex.Replace(input, "([a-z])([A-Z])", "$1-$2").ToLower();
			return result;
		}
	}
}
