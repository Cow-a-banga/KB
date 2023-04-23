using System;
using System.ComponentModel;
using KB.Models;

namespace Model.Models
{
    [Serializable]
    public class DomainValue
    {
        public DomainValue(string value)
        {
            Value = value;
        }

        [DisplayName("Значение")]
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}