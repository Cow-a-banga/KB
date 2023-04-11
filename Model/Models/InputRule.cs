using System;

namespace KB.Models
{
    [Serializable]
    public class InputRule:Rule
    {
        private string? _question;

        public string Question
        {
            get => _question ?? $"{VariableName} ?";
            set => _question = value;
        }
    }
}