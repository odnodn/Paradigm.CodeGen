using System;
using Paradigm.CodeGen.Input.Models.Definitions;
using Paradigm.CodeGen.Output.Models.Configuration;

namespace Paradigm.CodeGen.Output.TypeMatchers
{
    public class IsAbstractTypeMatcher : TypeMatcherBase
    {
        protected override bool IsMatch(TypeMatcherConfiguration configuration, ObjectDefinitionBase objectDefinition)
        {
            if (configuration.Parameters.Length != 0)
                throw new Exception("Is Abstract type matcher hasn't any arguments.");

            return objectDefinition.IsAbstract;
        }
    }
}