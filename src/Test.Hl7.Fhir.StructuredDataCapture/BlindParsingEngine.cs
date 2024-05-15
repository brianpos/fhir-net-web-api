using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Hl7.Fhir.StructuredDataCapture
{
	/// <summary>
	/// This is an implementation of <see cref="IFhirSerializationEngine"/> which uses the
	/// new Poco-based parser and serializer, initialized with the default settings.
	/// </summary>
	internal class BlindParsingEngine : IFhirSerializationEngine
	{
		private delegate bool TryDeserializer(string data, out Resource? instance, out IEnumerable<CodedException> issues);

		private readonly ModelInspector _inspector;
		private readonly Predicate<CodedException> _ignoreFilter;

		/// <summary>
		/// Creates an implementation of <see cref="IFhirSerializationEngine"/> that uses the newer POCO (de)serializers.
		/// </summary>
		/// <param name="inspector">Reflection data of the POCO model to use.</param>
		/// <param name="ignoreFilter">A predicate that returns true for issues that should not be reported.</param>
		public BlindParsingEngine(ModelInspector inspector, Predicate<CodedException> ignoreFilter)
		{
			_inspector = inspector;
			_ignoreFilter = ignoreFilter;
		}

		/// <summary>
		/// Creates an implementation of <see cref="IFhirSerializationEngine"/> that uses the newer POCO (de)serializers.
		/// </summary>
		/// <param name="inspector">Reflection data of the POCO model to use.</param>
		public BlindParsingEngine(ModelInspector inspector)
		{
			_inspector = inspector;
			_ignoreFilter = _ => false;
		}

		/// <inheritdoc />
		public Resource DeserializeFromXml(string data)
		{
			var deserializer = new BaseFhirXmlPocoDeserializer(_inspector);
			return deserializeAndIgnoreErrors(deserializer.TryDeserializeResource, data);
		}

		/// <inheritdoc />
		public Resource DeserializeFromJson(string data)
		{
			var deserializer = new BaseFhirJsonPocoDeserializer(_inspector);
			return deserializeAndIgnoreErrors(deserializer.TryDeserializeResource, data);
		}

		private Resource deserializeAndIgnoreErrors(TryDeserializer deserializer, string data)
		{
			bool success = deserializer(data, out var instance, out var issues);
			var relevantIssues = issues.Where(i => !_ignoreFilter(i)).ToList();

			return relevantIssues.Any() ? throw new DeserializationFailedException(instance, relevantIssues) : instance!;
		}

		public string SerializeToXml(Resource instance) => new BaseFhirXmlPocoSerializer(_inspector.FhirRelease).SerializeToString(instance);

		public string SerializeToJson(Resource instance) => new BaseFhirJsonPocoSerializer(_inspector.FhirRelease).SerializeToString(instance);
	}

}

