using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KB.Models;
using Model;
using Model.Consultation;
using Model.Models;

namespace Interface
{
    public partial class ConsultForm : Form
    {
        private KnowledgeBase _kb;
        private Variable _goal;
        private BindingList<string> questions;
        
        private TaskCompletionSource<string> tcs;
        public ConsultForm(KnowledgeBase kb)
        {
            InitializeComponent();
            _kb = kb;
            questions = new BindingList<string>();
            lbHistory.DataSource = questions;
            _goal = null;

        }

        private async void btnAnswer_Click(object sender, EventArgs e)
        {
            if (_goal == null)
            {
                _goal = _kb.Variables[cbAnswers.SelectedIndex];
                
                questions.Add($"Цель консультации: {_goal.Name}");
                questions.Add("");

                var consult = new Consultation(_kb, _goal, GetValueByUser);
                var result = await consult.Run();
            
                questions.Add($"Результат консультации:");
                questions.Add($"{_goal.Name} = {result.GoalValue ?? "NULL"}");
                questions.Add("Можете закрывать окно консультации");

                lbQuestion.Text = "";
                cbAnswers.DataSource = null;
                cbAnswers.Enabled = false;
                btnAnswer.Enabled = false;
            }
            else
            {
                var answer = (cbAnswers.SelectedItem as DomainValue).Value;
                questions.Add($"Вопрос: {lbQuestion.Text}");
                questions.Add($"Ответ: {answer}");
                questions.Add("");

                tcs.SetResult(answer);
            }
        }

        private async Task<string> GetValueByUser(Variable variable)
        {
            var domain = _kb.Domains.FirstOrDefault(x => x.Name == variable.Domain);
            cbAnswers.DataSource = domain.Values;
            lbQuestion.Text = $"{variable.Name}?";

            tcs = new TaskCompletionSource<string>();
            await tcs.Task;
            return tcs.Task.Result;
        }

        private void ConsultForm_Shown(object sender, EventArgs e)
        {
            lbQuestion.Text = "Выберите цель консультации";
            cbAnswers.DataSource = _kb.Variables;
        }
    }
}