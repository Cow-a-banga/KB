using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using KB.Models;

namespace Interface
{
    public partial class SaveRuleForm : Form
    {
        private KnowledgeBase _kb;
        private BindingList<Condition> _conditions;
        private Rule _rule;
        public SaveRuleForm(KnowledgeBase kb, Rule rule = null)
        {
            InitializeComponent();
            _kb = kb;
            _rule = rule;
            cbResVar.DataSource = _kb.Variables.ToList();
            cbVar.DataSource = _kb.Variables.ToList();

            if (rule != null)
            {
                tbName.Text = rule.Name;
                tbDescription.Text = rule.Details;
                _conditions = rule.Conditions;
                
                var varIndex = _kb.Variables
                    .Select((v, index) => (v, index))
                    .First(x => x.v.Name == _rule.VariableName).index;

                var valueIndex = _kb.Variables[varIndex].Domain
                    .Select((v, index) => (v, index))
                    .First(x => x.v.Name == _rule.SettingValue).index;
                cbResVar.SelectedIndex = varIndex;
                cbResValue.SelectedIndex = valueIndex;
            }
            else
            {
                tbName.Text = $"Rule_{_kb.Rules.Count}";
                _conditions = new BindingList<Condition>();
            }

            dgvConditions.DataSource = _conditions;
        }

        private void cbResVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbResValue.DataSource = _kb.Variables[cbResVar.SelectedIndex].Domain;
            cbResValue.SelectedIndex = 0;   
        }

        private void cbVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbValue.DataSource = _kb.Variables[cbVar.SelectedIndex].Domain;
            cbValue.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbVar.SelectedIndex == -1 || cbValue.SelectedIndex == -1)
                return;
            
            var condition = new Condition
            {
                VariableName = _kb.Variables[cbVar.SelectedIndex].Name,
                Value = _kb.Variables[cbVar.SelectedIndex].Domain[cbValue.SelectedIndex].Name
            };
            _conditions.Add(condition);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvConditions.CurrentCell != null)
            {
                _conditions.RemoveAt(dgvConditions.CurrentCell.RowIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbResValue.SelectedIndex == -1 || cbResVar.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните поля");
                return;
            }

                if (_rule == null)
            {
                var rule = new Rule();
                SetRuleProperties(rule);
                _kb.Rules.Add(rule);
            }
            else
            {
                SetRuleProperties(_rule);
            }
            
            Close();
        }

        private void SetRuleProperties(Rule rule)
        {
            rule.Name = string.IsNullOrWhiteSpace(tbName.Text) ? $"Rule_{_kb.Rules.Count}" : tbName.Text;
            rule.Conditions = _conditions;
            rule.VariableName = _kb.Variables[cbResVar.SelectedIndex].Name;
            rule.SettingValue = _kb.Variables[cbResVar.SelectedIndex].Domain[cbResValue.SelectedIndex].Name;
            rule.Details = tbDescription.Text;
        }
    }
}