using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Model;
using Model.Models;

namespace KB.Models
{

    public enum AddResult
    {
        Success,
        NoName,
        Duplicate
    }
    
    public enum UpdateResult
    {
        Success,
        NoName,
        Duplicate,
        NoIndex
    }
    
    public enum RemoveResult
    {
        Success,
        Used
    }
    
    [Serializable]
    public class KnowledgeBase
    {
        public BindingList<Rule> Rules { get; set; } = new BindingList<Rule>();
        public BindingList<Variable> Variables { get; set; } = new BindingList<Variable>();
        public BindingList<Domain> Domains { get; set; } = new BindingList<Domain>();
        public WorkingMemory WorkingMemory { get; set; }

        public AddResult AddVariable(Variable variable)
        {
            if (string.IsNullOrWhiteSpace(variable.Name))
                return AddResult.NoName;

            if (Variables.FirstOrDefault(x => x.Name == variable.Name) != null)
                return AddResult.Duplicate;

            if (Domains.All(x => x.Name != variable.Domain))
            {
                Domains.Add(new Domain{Name = variable.Domain});
            }
            
            Variables.Add(variable);
            return AddResult.Success;
        }
        
        public AddResult AddDomain(Domain domain)
        {
            if (string.IsNullOrWhiteSpace(domain.Name))
                return AddResult.NoName;

            if (Domains.FirstOrDefault(x => x.Name == domain.Name) != null)
                return AddResult.Duplicate;
            
            Domains.Add(domain);
            return AddResult.Success;
        }
        
        

        public UpdateResult UpdateVariable(string name, string domain, VariableType type,  int index)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(domain))
                return UpdateResult.NoName;

            if (index < 0 || index >= Variables.Count)
                return UpdateResult.NoIndex;

            if (Variables[index].Name != name && Variables.FirstOrDefault(x => x.Name == name) != null)
                return UpdateResult.Duplicate;
            
            if (Domains.All(x => x.Name != domain))
            {
                Domains.Add(new Domain{Name = domain});
            }

            Variables[index].Name = name;
            Variables[index].VariableType = type;
            Variables[index].Domain = domain;
            return UpdateResult.Success;
        }
        
        public UpdateResult UpdateDomain(string name, int index)
        {
            if (string.IsNullOrWhiteSpace(name))
                return UpdateResult.NoName;

            if (index < 0 || index >= Domains.Count)
                return UpdateResult.NoIndex;

            if (Domains[index].Name != name && Domains.FirstOrDefault(x => x.Name == name) != null)
                return UpdateResult.Duplicate;

            Domains[index].Name = name;
            return UpdateResult.Success;
        }
        
        public (RemoveResult, List<string>) RemoveDomain(int index)
        {
            var domain = Domains[index];
            var variables = Variables.Where(x => x.Domain == domain.Name).Select(x => x.Name).ToList();
            if (variables.Count > 0)
            {
                return (RemoveResult.Used, variables);
            }
            
            Domains.RemoveAt(index);
            return (RemoveResult.Success, null);
        }
        
        public (RemoveResult, List<string>) RemoveVariable(int index)
        {
            var variable = Variables[index];
            var rules = Rules
                .Where(x => x.VariableName == variable.Name 
                            || x.Conditions.Any(r => r.VariableName == variable.Name))
                .Select(x => x.Name).ToList();
            if (rules.Count > 0)
            {
                return (RemoveResult.Used, rules);
            }
            
            Variables.RemoveAt(index);
            return (RemoveResult.Success, null);
        }

        public Variable GetVariable(string name)
        {
            return Variables.FirstOrDefault(x => x.Name == name);
        }
    }
}