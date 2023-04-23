using System;
using System.ComponentModel;
using System.Linq;
using KB.Models;
using Model.Models;

namespace Model
{
    [Serializable]
    public class Domain
    {
        [DisplayName("Название")]
        public string Name { get; set; }
        public BindingList<DomainValue> Values { get; set; } = new BindingList<DomainValue>();

        public AddResult AddDomain(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return AddResult.NoName;

            if (Values.FirstOrDefault(x => x.Value == domain) != null)
                return AddResult.Duplicate;
            
            Values.Add(new DomainValue(domain));
            return AddResult.Success;
        }

        public UpdateResult UpdateDomain(string domain, int index)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return UpdateResult.NoName;

            if (index < 0 || index >= Values.Count)
                return UpdateResult.NoIndex;

            if (Values[index].Value != domain && Values.FirstOrDefault(x => x.Value == domain) != null)
                return UpdateResult.Duplicate;

            Values[index].Value = domain;
            return UpdateResult.Success;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}