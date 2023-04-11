using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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
    
    [Serializable]
    public class KnowledgeBase
    {
        public BindingList<Rule> Rules { get; set; } = new BindingList<Rule>();
        public BindingList<Variable> Variables { get; set; } = new BindingList<Variable>();
        public WorkingMemory WorkingMemory { get; set; }

        public AddResult AddVariable(Variable variable)
        {
            if (string.IsNullOrWhiteSpace(variable.Name))
                return AddResult.NoName;

            if (Variables.FirstOrDefault(x => x.Name == variable.Name) != null)
                return AddResult.Duplicate;
            
            Variables.Add(variable);
            return AddResult.Success;
        }

        public UpdateResult UpdateVariable(string name, VariableType type,  int index)
        {
            if (string.IsNullOrWhiteSpace(name))
                return UpdateResult.NoName;

            if (index < 0 || index >= Variables.Count)
                return UpdateResult.NoIndex;

            if (Variables[index].Name != name && Variables.FirstOrDefault(x => x.Name == name) != null)
                return UpdateResult.Duplicate;

            Variables[index].Name = name;
            Variables[index].VariableType = type;
            return UpdateResult.Success;
        }

        public Variable GetVariable(string name)
        {
            return Variables.FirstOrDefault(x => x.Name == name);
        }
    }
}