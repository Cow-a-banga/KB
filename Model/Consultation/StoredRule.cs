using System;
using KB.Models;

namespace Model.Consultation
{
    public enum StoredRuleStatus
    {
        Correct,
        Incorrect,
        Unknown
    }
    
    [Serializable]
    public class StoredRule
    {
        public StoredRule(Rule rule, StoredRuleStatus status = StoredRuleStatus.Unknown)
        {
            Rule = rule;
            Status = status;
        }

        public Rule Rule { get; }
        public StoredRuleStatus Status { get; set; }

        public override string ToString()
        {
            return $"ЕСЛИ ({Rule.ConditionsString}), ТО {Rule.ResultString}";
        }
    }
}