using System;

namespace KB.Models
{
    [Serializable]
    public class Condition
    {
        public string VariableName { get; set; }
        public string Value { get; set; }
    }
}