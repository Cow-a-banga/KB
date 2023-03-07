using System;
using System.Linq;
using System.Windows.Forms;
using KB.Models;

namespace Interface
{
    public partial class MainForm : Form
    {
        private KnowledgeBase _knowledgeBase;
        public MainForm()
        {
            _knowledgeBase = new KnowledgeBase();

            InitializeComponent();
            dgvRules.DataSource = _knowledgeBase.Rules;
            dgvVariables.DataSource = _knowledgeBase.Variables;
            foreach (DataGridViewColumn column in dgvRules.Columns)
                column.ReadOnly = true;



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _knowledgeBase.Rules.Add(new Rule{Name = $"Name {_knowledgeBase.Rules.Count}"});
        }

        private void AddCommon(AddResult status, TextBox textBox)
        {
            switch (status)
            {
                case AddResult.Success:
                    textBox.Text = String.Empty;
                    break;
                case AddResult.NoName:
                    MessageBox.Show("Заполните имя");
                    break;
                case AddResult.Duplicate:
                    MessageBox.Show("Попытка добавить дупликат");
                    break;
            }
        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            var name = tbVariable.Text;
            var status = _knowledgeBase.AddVariable(new Variable(name));
            AddCommon(status, tbVariable);
        }

        private void dgvVariables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell == null) return;
            tbVariable.Text = _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex].Name;
                
            dgvDoman.DataSource = _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex].Domain;
            foreach (DataGridViewColumn column in dgvDoman.Columns)
                column.ReadOnly = true;

        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            var name = tbDomain.Text;
            var status = _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex].AddDomain(name);
            AddCommon(status, tbDomain);
        }

        private void UpdateCommon(UpdateResult status)
        {
            switch (status)
            {
                case UpdateResult.Success:
                    break;
                case UpdateResult.NoName:
                    MessageBox.Show("Заполните имя");
                    break;
                case UpdateResult.Duplicate:
                    MessageBox.Show("Попытка добавить дупликат");
                    break;
                case UpdateResult.NoIndex:
                    MessageBox.Show("Ошибка при выборе элемента");
                    break;
            }
        }
        
        private void btnUpdateDomain_Click(object sender, EventArgs e)
        {
            var name = tbDomain.Text;
            var status = _knowledgeBase
                .Variables[dgvVariables.CurrentCell.RowIndex]
                .UpdateDomain(name, dgvDoman.CurrentCell.RowIndex);
            UpdateCommon(status);
        }

        private void btnDeleteDomain_Click(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell != null && dgvDoman.CurrentCell != null)
            {
                _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex].Domain.RemoveAt(dgvDoman.CurrentCell.RowIndex);
            }
        }

        private void dgvDoman_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvVariables.CurrentCell == null)
                return;

            var domains = _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex].Domain;

            if(dgvDoman.CurrentCell.RowIndex <= domains.Count - 1)
                tbDomain.Text = domains[dgvDoman.CurrentCell.RowIndex].Name;
        }

        private void btnDeleteVariable_Click(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell != null)
            {
                _knowledgeBase.Variables.RemoveAt(dgvVariables.CurrentCell.RowIndex);
                
                if(dgvVariables.Rows.Count == 0)
                    dgvDoman.DataSource = null;
            }
        }

        private void btnUpdateVariable_Click(object sender, EventArgs e)
        {
            var name = tbVariable.Text;
            var status = _knowledgeBase
                .UpdateVariable(name, dgvVariables.CurrentCell.RowIndex);
            UpdateCommon(status);
        }
    }
}