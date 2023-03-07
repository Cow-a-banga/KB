namespace KB.Models
{
    public class Condition
    {
        public Variable Variable { get; set; }
        public string Value { get; set; }

        public bool IsPassed => Variable.CurrentValue == Value;
    }
}