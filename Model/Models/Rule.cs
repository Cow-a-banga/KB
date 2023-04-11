using System;
using System.ComponentModel;
using System.Linq;

namespace KB.Models
{
    [Serializable]
    public class Rule
    {
        [Browsable(false)]
        public string Name { get; set; }
        [Browsable(false)]
        public string VariableName { get; set; }
        [Browsable(false)]
        public string SettingValue { get; set; }
        public BindingList<Condition> Conditions { get; set; }
        [Browsable(false)]
        public string Details { get; set; }

        [DisplayName("Заключение")]
        public string ResultString => $"{VariableName} = {SettingValue}";

        [DisplayName("Посылка")]
        public string ConditionsString => 
            string.Join(" И ", Conditions?.Select(x => $"{x.VariableName} = {x.Value}") ?? Array.Empty<string>());



    }
}