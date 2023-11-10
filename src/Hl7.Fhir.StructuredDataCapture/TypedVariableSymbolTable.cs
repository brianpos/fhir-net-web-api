using Hl7.Fhir.ElementModel;
using Hl7.Fhir.FhirPath.Validator;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.FhirPath.Expressions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Hl7.Fhir.StructuredDataCapture
{
	public class TypedVariableSymbolTable : SymbolTable
	{
		public TypedVariableSymbolTable(): base()
		{
		}

		public TypedVariableSymbolTable(SymbolTable parent) : base(parent)
		{
		}

		public void AddVar(string name, IEnumerable<ITypedElement> value, ClassMapping cm)
		{
			this.Add(name, () => { return value; });
			RegisterVariable(name, cm);
		}

		public void AddVar(string name, IEnumerable<ITypedElement> value, FhirPathVisitorProps props)
		{
			this.Add(name, () => { return value; });
			RegisterVariable(name, props);
		}

		public void AddVar(string name, IEnumerable<ITypedElement> value, Type t = null)
		{
			this.Add(name, () => { return value; });
			RegisterVariable(name, t);
		}

		public void AddVar(string name, ITypedElement value, Type t)
		{
			(this as SymbolTable).AddVar(name, value);
			RegisterVariable(name, t);
		}

		public void RegisterVariable(string name, Type t)
		{
			ClassMapping cm = null;
			if (t != null)
				cm = ModelInfo.ModelInspector.FindClassMapping(t);
			RegisterVariable(name, cm);
		}

		public void RegisterVariable(string name, ClassMapping cm)
		{
			FhirPathVisitorProps props = new FhirPathVisitorProps();
			if (cm != null)
				props.Types.Add(new NodeProps(cm));
			else
			{
				// This could be anything!
				foreach (var sr in ModelInfo.SupportedResources)
				{
					props.Types.Add(new NodeProps(ModelInfo.ModelInspector.FindClassMapping(sr)));
				}
			}
			RegisterVariable(name, props);
		}

		public void RegisterVariable(string name, FhirPathVisitorProps props)
		{
			_variables.Add(name, props);
		}

		private Dictionary<string, FhirPathVisitorProps> _variables = new Dictionary<string, FhirPathVisitorProps>();

		// GetVariableMappings: returns an IEnumerable of the _variables collection appended to the parent's variables
		public IEnumerable<KeyValuePair<string, FhirPathVisitorProps>> GetVariableMappings()
		{
			if (Parent is TypedVariableSymbolTable tvst)
			{
				foreach (var sr in tvst.GetVariableMappings())
					yield return sr;
			}
			foreach (var sr in _variables)
			{
				yield return sr;
			}
		}
	}
}
