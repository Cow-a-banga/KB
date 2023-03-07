using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Model;

namespace KB.Models
{
    public class Variable
    {
        public Variable(string name)
        {
            _currentValueIndex = -1;
            Name = name;
        }

        public string Name { get; set; }
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
        

        public string? CurrentValue => _currentValueIndex < 0 || _currentValueIndex > Domain.Count
            ? null
            : Domain[_currentValueIndex].Name;

        private int _currentValueIndex;
    }
}
