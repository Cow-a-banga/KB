using System.Collections.Generic;
using System.ComponentModel;

namespace KB.Models
{
    public class Rule
    {
        [DisplayName("Название")]
        public string Name { get; set; }
        [Browsable(false)]
        public Variable Variable { get; set; }
        [Browsable(false)]
        public string SettingValue { get; set; }
        public List<Condition> Conditions { get; set; }
        [Browsable(false)]
        public string Details { get; set; }
    }
}