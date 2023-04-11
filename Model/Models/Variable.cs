using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public Variable(string name, VariableType variableType = VariableType.Calculating)
        {
            Name = name;
            VariableType = variableType;
        }

        [DisplayName("Переменная")]
        public string Name { get; set; }
        
        [DisplayName("Тип")]
        public VariableType VariableType { get; set; }
        public BindingList<Domain> Domain { get; set; } = new BindingList<Domain>();

        public AddResult AddDomain(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return AddResult.NoName;

            if (Domain.FirstOrDefault(x => x.Name == domain) != null)
                return AddResult.Duplicate;
            
            Domain.Add(new Domain{Name = domain});
            return AddResult.Success;
        }
        
        public UpdateResult UpdateDomain(string domain, int index)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return UpdateResult.NoName;

            if (index < 0 || index >= Domain.Count)
                return UpdateResult.NoIndex;

            if (Domain[index].Name != domain && Domain.FirstOrDefault(x => x.Name == domain) != null)
                return UpdateResult.Duplicate;

            Domain[index].Name = domain;
            return UpdateResult.Success;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
