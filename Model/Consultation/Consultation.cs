using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KB.Models;

namespace Model.Consultation
{
    public class Consultation
    {
        private KnowledgeBase _kb;
        private Variable _goal;
        private Func<Variable, Task<string>> _getValueByUser;
        
        private List<StoredVariable> StoredVariables = new List<StoredVariable>();
        private List<StoredRule> StoredRules = new List<StoredRule>();
        private IEnumerable<string> UsedRules => StoredRules.Select(x => x.Rule.Name); 
        private StoredVariable FindStoredVariable(string name) => 
            StoredVariables.FirstOrDefault(x => x.Variable.Name == name);
        private StoredRule FindStoredRule(string name) => 
            StoredRules.FirstOrDefault(x => x.Rule.Name == name);
        public Consultation(KnowledgeBase kb, Variable goal, Func<Variable, Task<string>> getValueByUser)
        {
            _kb = kb;
            _goal = goal;
            _getValueByUser = getValueByUser;
        }
        public async Task<WorkingMemory> Run()
        {
            var value =  await GetValueForVariable(_goal);
            var memory =  new WorkingMemory
            {
                Goal = _goal,
                Rules = StoredRules,
                Variables = StoredVariables,
                GoalValue = value
            };

            _kb.WorkingMemory = memory;
            return memory;
        }
        private List<Rule> FindRulesForVariable(Variable variable)
        {
            return _kb.Rules
                .Where(x => x.VariableName == variable.Name && !UsedRules.Contains(variable.Name))
                .ToList();
        }
        private void SaveVariable(Variable variable, string value)
        {
            var knownVariable = FindStoredVariable(variable.Name);
            if (knownVariable != null)
            {
                knownVariable.Value = value;
            }
            else
            {
                var storedVariable = new StoredVariable(variable, value);
                StoredVariables.Add(storedVariable);
            }
        }
        
        private void SaveRule(Rule rule, StoredRuleStatus status)
        {
            var knownRule = FindStoredRule(rule.Name);
            if (knownRule != null)
            {
                knownRule.Status = status;
            }
            else
            {
                var storedRule = new StoredRule(rule, status);
                StoredRules.Add(storedRule);
            }
        }
        
        private async Task<string> GetValueForVariable(Variable findingVariable)
        {
            var knownVariable = FindStoredVariable(findingVariable.Name);
            if (knownVariable != null)
            {
                return knownVariable.Value;
            }
            if (findingVariable.VariableType == VariableType.Inputting)
            {
                var value = await _getValueByUser(findingVariable);
                SaveVariable(findingVariable, value);
                return value;
            }
            var currentRules = FindRulesForVariable(findingVariable);
            foreach (var rule in currentRules)
            {
                bool ruleWorked = true;
                foreach (var condition in rule.Conditions)
                {
                    var currentVariable = _kb.GetVariable(condition.VariableName);
                    var currentVariableValue = await GetValueForVariable(currentVariable);
                    SaveVariable(currentVariable, currentVariableValue);
                    if (currentVariableValue != condition.Value)
                    {
                        ruleWorked = false;
                        break;
                    }
                }
                if (ruleWorked)
                {
                    SaveRule(rule, StoredRuleStatus.Correct);
                    SaveVariable(findingVariable, rule.SettingValue);
                    return rule.SettingValue;
                }
            }
            
            if (findingVariable.VariableType == VariableType.CalculatingInputting)
            {
                var value = await _getValueByUser(findingVariable);
                SaveVariable(findingVariable, value);
                return value;
            }
            
            SaveVariable(findingVariable, null);
            return null;
        }
    }
}