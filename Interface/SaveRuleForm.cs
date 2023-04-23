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
        private int? _index;
        public SaveRuleForm(KnowledgeBase kb, Rule rule = null, int? selectedIndex = null)
        {
            InitializeComponent();
            _kb = kb;
            _index = selectedIndex;
            _rule = rule;
            BindComboBoxes();

            if (rule != null)
            {
                tbName.Text = rule.Name;
                tbDescription.Text = rule.Details;
                _conditions = rule.Conditions;
                
                var varIndex = _kb.Variables
                    .Select((v, index) => (v, index))
                    .First(x => x.v.Name == _rule.VariableName).index;
                
                var valueIndex = _kb.Domains
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

        private void BindComboBoxes()
        {
            cbResVar.DataSource = _kb.Variables.Where(x => x.VariableType != VariableType.Inputting).ToList();
            cbVar.DataSource = _kb.Variables;
            BindDomainComboBox(cbResVar, cbResValue);
            BindDomainComboBox(cbVar, cbValue);
        }

        private void BindDomainComboBox(ComboBox variableComboBox, ComboBox valueComboBox)
        {
            var variable = _kb.Variables.FirstOrDefault(x => x.Name == variableComboBox.Text);
            if (variable != null)
            {
                var domain = _kb.Domains.FirstOrDefault(x => x.Name == variable.Domain);
                valueComboBox.DataSource = domain.Values;
            }
        }

        private void cbResVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDomainComboBox(cbResVar, cbResValue);
            cbResValue.SelectedIndex = 0;   
        }

        private void cbVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDomainComboBox(cbVar, cbValue);
            cbValue.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbVar.Text) || string.IsNullOrWhiteSpace(cbValue.Text))
                return;
            
            var condition = new Condition
            {
                VariableName = cbVar.Text,
                Value = cbValue.Text
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
            if (string.IsNullOrWhiteSpace(cbResValue.Text) || string.IsNullOrWhiteSpace(cbResVar.Text) || _conditions.Count == 0)
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            if (_rule == null)
            {
                _rule = new Rule();
                SetRuleProperties(_rule);
                if (_index.HasValue)
                {
                    _kb.Rules.Insert(_index.Value + 1, _rule);
                }
                else
                {
                    _kb.Rules.Add(_rule);
                }
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
            rule.VariableName = cbResVar.Text;
            rule.SettingValue = cbResValue.Text;
            rule.Details = tbDescription.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contextAddingForm = new ContextAddVariable(_kb);
            contextAddingForm.StartPosition = FormStartPosition.CenterParent;
            contextAddingForm.ShowDialog();
            BindComboBoxes();
        }
    }
}