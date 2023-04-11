using System;
using System.Collections.Generic;
using System.Linq;
using Model.Consultation;

namespace KB.Models
{
    [Serializable]
    public class WorkingMemory
    {
        public List<StoredRule> Rules { get; set; }
        public List<StoredVariable> Variables { get; set; }
        public Variable Goal { get; set; }
        public string GoalValue { get; set; }

        public StoredRule GoalRule => Rules.FirstOrDefault(x => x.Rule.VariableName == Goal.Name);
        public List<StoredRule> RulesForVariable(string v) => Rules.Where(x => x.Rule.VariableName == v).ToList();
        public StoredVariable VariableByName(string v) => Variables.FirstOrDefault(x => x.Variable.Name == v);
    }
}