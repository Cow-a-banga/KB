namespace KB.Models
{
    public class InputRule:Rule
    {
        private string? _question;

        public string Question
        {
            get => _question ?? $"{Variable.Name} ?";
            set => _question = value;
        }
    }
}