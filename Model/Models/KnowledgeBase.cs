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
    
    public class KnowledgeBase
    {
        public BindingList<Rule> Rules { get; set; } = new BindingList<Rule>();
        public List<InputRule> InputRules { get; set; } = new List<InputRule>();
        public Variable Goal { get; set; }
        public BindingList<Variable> Variables { get; set; } = new BindingList<Variable>();

        public AddResult AddVariable(Variable variable)
        {
            if (string.IsNullOrWhiteSpace(variable.Name))
                return AddResult.NoName;

            if (Variables.FirstOrDefault(x => x.Name == variable.Name) != null)
                return AddResult.Duplicate;
            
            Variables.Add(variable);
            return AddResult.Success;
        }

        public UpdateResult UpdateVariable(string name, int index)
        {
            if (string.IsNullOrWhiteSpace(name))
                return UpdateResult.NoName;

            if (index < 0 || index >= Variables.Count)
                return UpdateResult.NoIndex;

            if (Variables[index].Name != name && Variables.FirstOrDefault(x => x.Name == name) != null)
                return UpdateResult.Duplicate;

            Variables[index].Name = name;
            return UpdateResult.Success;
        }
    }
}