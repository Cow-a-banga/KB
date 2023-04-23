using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Windows.Forms;
using KB.Models;
using Model;
using Model.Consultation;

namespace Interface
{
    public partial class MainForm : Form
    {
        private KnowledgeBase _knowledgeBase;
        private string _currentFilePath;
        public MainForm()
        {
            _knowledgeBase = new KnowledgeBase();

            InitializeComponent();
            KeyPreview = true;
            KeyDown += Form_KeyDown;
            BindLists();
            foreach (DataGridViewColumn column in dgvRules.Columns)
                column.ReadOnly = true;
        }

        private void BindLists()
        {
            dgvRules.DataSource = _knowledgeBase.Rules;
            dgvVariables.DataSource = _knowledgeBase.Variables;
            dgvDomain.DataSource = _knowledgeBase.Domains;
            cbDomain.DataSource = _knowledgeBase.Domains;
            cbType.DataSource = Enum.GetValues(typeof(VariableType));
            BuildTree();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int? index = null;
            if (dgvRules.CurrentCell != null)
            {
                index = dgvRules.CurrentCell.RowIndex;
            }
            
            var createRuleForm = new SaveRuleForm(_knowledgeBase, selectedIndex:index);
            createRuleForm.StartPosition = FormStartPosition.CenterParent;
            createRuleForm.ShowDialog();
        }

        private void AdditionOutput(AddResult status)
        {
            switch (status)
            {
                case AddResult.Success:
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
            var type = (VariableType) cbType.SelectedItem;
            var domain = cbDomain.Text;
            var status = _knowledgeBase.AddVariable(new Variable(name, domain, type));
            
            AdditionOutput(status);
        }

        private void dgvVariables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell == null) return;
            
            var selectedVar = _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex];
            tbVariable.Text = selectedVar.Name;
            cbType.SelectedIndex = (int) selectedVar.VariableType;
            var domainName = selectedVar.Domain;
            cbDomain.SelectedIndex = _knowledgeBase.Domains
                .Select((x, index) => (x.Name, index))
                .FirstOrDefault(x => x.Name == domainName).index;

            var rulesUsing = _knowledgeBase.Rules.Where(x =>
                    x.VariableName == selectedVar.Name || x.Conditions.Any(c => c.VariableName == selectedVar.Name))
                .Select(x => x.Name)
                .ToList();

            lbVariableInRules.DataSource = rulesUsing;
            
            if (rulesUsing.Count > 0)
            {
                btnDeleteVariable.Enabled = false;
                btnUpdateVariable.Enabled = false;
            }
            else
            {
                btnDeleteVariable.Enabled = true;
                btnUpdateVariable.Enabled = true;
            }
        }
        
        private void dgvDomain_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDomain.CurrentCell == null) return;
            
            var selected = _knowledgeBase.Domains[dgvDomain.CurrentCell.RowIndex];
            tbDomain.Text = selected.Name;
            
            dgvDomainValue.DataSource = selected.Values;

            var domainUsing = _knowledgeBase.Variables.Any(x => x.Domain == selected.Name);
            if (domainUsing)
            {
                btnDeletDomain.Enabled = false;
                btnEditDomen.Enabled = false;
            }
            else
            {
                btnDeletDomain.Enabled = true;
                btnEditDomen.Enabled = true;
            }
        }
        
        private void dgvDomainValue_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDomain.CurrentCell == null || dgvDomainValue.CurrentCell == null) return;
            
            var selected = _knowledgeBase.Domains[dgvDomain.CurrentCell.RowIndex];
            var index = dgvDomainValue.CurrentCell.RowIndex;

            if (index >= selected.Values.Count)
            {
                dgvDomainValue.ClearSelection();
                return;
            }
            
            var domainValue = selected.Values[index].Value;

            tbDomainValue.Text = domainValue;


            var domainValueUsing = _knowledgeBase.Rules.Any(x =>
                x.SettingValue == domainValue || x.Conditions.Any(c => c.Value == domainValue));
            if (domainValueUsing)
            {
                btnEditDomainValue.Enabled = false;
                btnRemoveDomainValue.Enabled = false;
            }
            else
            {
                btnEditDomainValue.Enabled = true;
                btnRemoveDomainValue.Enabled = true;
            }
        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            var name = tbDomain.Text;
            var status = _knowledgeBase.AddDomain(new Domain{Name = name});
            AdditionOutput(status);
        }

        private void UpdatingOutput(UpdateResult status)
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
        
        private void RemoveOutput(RemoveResult status, List<string> elements, bool isDomain = true)
        {
            switch (status)
            {
                case RemoveResult.Success:
                    break;
                case RemoveResult.Used:
                    var text = isDomain ? "Сперва удалите переменные:" : "Сперва удалите правила:";
                    text = $"{text}\n{string.Join('\n',elements)}";
                    MessageBox.Show(text);
                    break;
            }
        }
        
        private void btnUpdateDomain_Click(object sender, EventArgs e)
        {
            if (dgvDomain.CurrentCell != null)
            {
                var name = tbDomain.Text;
                var status = _knowledgeBase
                    .UpdateDomain(name, dgvDomain.CurrentCell.RowIndex);
                UpdatingOutput(status);
            }
        }

        private void btnDeleteDomain_Click(object sender, EventArgs e)
        {
            if (dgvDomain.CurrentCell != null)
            {
                var (status, list) = _knowledgeBase.RemoveDomain(dgvDomain.CurrentCell.RowIndex);
                RemoveOutput(status, list);
            }
        }

        private void btnDeleteVariable_Click(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell != null)
            {
                var (status, list) = _knowledgeBase.RemoveVariable(dgvVariables.CurrentCell.RowIndex);
                RemoveOutput(status, list, false);
            }
        }

        private void btnUpdateVariable_Click(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell != null)
            {
                var name = tbVariable.Text;
                var type = (VariableType) cbType.SelectedItem;
                var domain = cbDomain.Text;
                var status = _knowledgeBase
                    .UpdateVariable(name, domain, type, dgvVariables.CurrentCell.RowIndex);
                UpdatingOutput(status);
                dgvVariables.Invalidate();
            }
        }
        
        private void btnAddDomainValue_Click(object sender, EventArgs e)
        {
            var name = tbDomainValue.Text;
            var selected = _knowledgeBase.Domains[dgvDomain.CurrentCell.RowIndex];
            var status = selected.AddDomain(name);
            AdditionOutput(status);
            dgvDomainValue.Invalidate();
        }

        private void btnEditDomainValue_Click(object sender, EventArgs e)
        {
            var name = tbDomainValue.Text;
            var selected = _knowledgeBase.Domains[dgvDomain.CurrentCell.RowIndex];
            var valueIndex = dgvDomainValue.CurrentCell.RowIndex;
            var status = selected.UpdateDomain(name, valueIndex);
            UpdatingOutput(status);
                
            dgvDomainValue.Invalidate();
        }

        private void btnRemoveDomainValue_Click(object sender, EventArgs e)
        {
            var selected = _knowledgeBase.Domains[dgvDomain.CurrentCell.RowIndex];
            var valueIndex = dgvDomainValue.CurrentCell.RowIndex;
            selected.Values.RemoveAt(valueIndex);
        }

        private void btnEditRule_Click(object sender, EventArgs e)
        {
            if (dgvRules.CurrentCell != null)
            {
                var rule = _knowledgeBase.Rules[dgvRules.CurrentCell.RowIndex];
                var updateRuleForm = new SaveRuleForm(_knowledgeBase, rule);
                updateRuleForm.StartPosition = FormStartPosition.CenterParent;
                updateRuleForm.ShowDialog();
            }
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            if (dgvRules.CurrentCell != null)
            {
                _knowledgeBase.Rules.RemoveAt(dgvRules.CurrentCell.RowIndex);
            }
        }
        private void BuildTree()
        {
            tvMemory.Nodes.Clear();
            
            if (_knowledgeBase.WorkingMemory == null || !_knowledgeBase.Rules.Any())
            {
                return;
            }

            var node = new TreeNode();
            var rule = _knowledgeBase.WorkingMemory.GoalRule;
            node.Text = rule.ToString();
            
            BuildSubTree(node, rule);
            tvMemory.Nodes.Add(node);
            tvMemory.ExpandAll();
        }

        private void BuildSubTree(TreeNode subTree, StoredRule storedRule)
        {
            foreach (var condition in storedRule.Rule.Conditions)
            {
                var rules = _knowledgeBase.WorkingMemory.RulesForVariable(condition.VariableName);

                if (rules.Count == 0)
                {
                    var variable = _knowledgeBase.WorkingMemory.VariableByName(condition.VariableName);
                    if (variable.Variable.VariableType == VariableType.Calculating) continue;
                    
                    var node = new TreeNode {Text = $"{variable.Variable.Name} = {variable.Value} (Вводимая)"};
                    subTree.Nodes.Add(node);

                }
                else
                {
                    foreach (var rule in rules)
                    {
                        var node = new TreeNode {Text = rule.ToString()};
                        subTree.Nodes.Add(node);
                        BuildSubTree(node, rule);
                    }
                }
            }
        }

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _knowledgeBase.WorkingMemory = null;
            var form = new ConsultForm(_knowledgeBase);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Closed += (o, args) => {
                BuildTree();
                tabControl.SelectedIndex = 3;
            };
            form.ShowDialog();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "data";
            openFileDialog.DefaultExt = ".bin";
            openFileDialog.Filter = @"Binary files (.bin)|*.bin"; 
            var formatter = new BinaryFormatter();
            
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream;
                if((stream = openFileDialog.OpenFile()) != null)
                {
                    _knowledgeBase = (KnowledgeBase)formatter.Deserialize(stream);
                    BindLists();
                    stream.Close();
                    сохранитьToolStripMenuItem.Enabled = true;
                    _currentFilePath = openFileDialog.FileName;
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "data";
            saveFileDialog.DefaultExt = ".bin";
            saveFileDialog.Filter = @"Binary files (.bin)|*.bin"; 
            var formatter = new BinaryFormatter();
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream;
                if((stream = saveFileDialog.OpenFile()) != null)
                {
                    formatter.Serialize(stream, _knowledgeBase);
                    stream.Close();
                }
            }
        }
        
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (_currentFilePath != null)
            {
                var formatter = new BinaryFormatter();
                Stream stream = new FileStream(_currentFilePath, FileMode.Truncate);
                formatter.Serialize(stream, _knowledgeBase);
                stream.Close();
            }
        }

        private void Form_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                if (tabControl.SelectedIndex == 0)
                {
                    _knowledgeBase.Rules.ReverseInPlace();
                }
                else if (tabControl.SelectedIndex == 1)
                {
                    _knowledgeBase.Variables.ReverseInPlace();
                }

                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                Save();
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabIndex = tabControl.SelectedIndex;

            switch (tabIndex)
            {
                case 0:
                    dgvRules.ClearSelection();
                    if (_knowledgeBase.Rules.Count > 0)
                        dgvRules.CurrentCell = dgvRules.Rows[0].Cells[0];
                    break;
                case 1:
                    dgvVariables.ClearSelection();
                    if(_knowledgeBase.Variables.Count > 0)
                        dgvVariables.CurrentCell = dgvVariables.Rows[0].Cells[0];
                    break;
                case 2:
                    dgvDomain.ClearSelection();
                    if(_knowledgeBase.Domains.Count > 0)
                        dgvDomain.CurrentCell = dgvDomain.Rows[0].Cells[0];
                    dgvDomainValue.ClearSelection();
                    if(_knowledgeBase.Domains.Count > 0 && _knowledgeBase.Domains[0].Values.Count > 0)
                        dgvDomainValue.CurrentCell = dgvDomainValue.Rows[0].Cells[0];
                    break;
            }
        }

        private void импортПравилToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = new StreamReader(openFileDialog.FileName);
                var text = stream.ReadToEnd();
                var kb = JsonSerializer.Deserialize<BindingList<Rule>>(text);
                _knowledgeBase.Rules = kb;
            }
        }
    }
}