using System;
using System.ComponentModel;
using System.Linq;
using Model;

namespace KB.Models
{
    public enum VariableType
    {
        [Description("Выводимая")]
        Calculating,
        [Description("Запрашиваемая")]
        Inputting,
        [Description("Запрашиваемо-выводимая")]
        CalculatingInputting
    }
    
    [Serializable]
    public class Variable
    {
        public Variable(string name, string domain, VariableType variableType = VariableType.Calculating)
        {
            Name = name;
            VariableType = variableType;
            Domain = domain;
        }

        [DisplayName("Переменная")]
        public string Name { get; set; }
        
        [DisplayName("Тип")]
        public VariableType VariableType { get; set; }
        public string Domain { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
