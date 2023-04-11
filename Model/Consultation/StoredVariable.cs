using System;
using KB.Models;

namespace Model.Consultation
{
    [Serializable]
    public class StoredVariable
    {
        public Variable Variable { get; }
        public string Value { get; set; }
        

        public StoredVariable(Variable variable, string value)
        {
            Variable = variable;
            Value = value;
        }
    }
}