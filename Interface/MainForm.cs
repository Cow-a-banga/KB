using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using KB.Models;
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
            KeyDown += new KeyEventHandler(Form_KeyDown);
            BindLists();
            foreach (DataGridViewColumn column in dgvRules.Columns)
                column.ReadOnly = true;
        }

        private void BindLists()
        {
            dgvRules.DataSourceRows = _knowledgeBase.Rules;
            dgvVariables.DataSourceRows = _knowledgeBase.Variables;
            cbType.DataSource = Enum.GetValues(typeof(VariableType));
            BuildTree();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var createRuleForm = new SaveRuleForm(_knowledgeBase);
            createRuleForm.StartPosition = FormStartPosition.CenterParent;
            createRuleForm.ShowDialog();
        }

        private void AdditionOutput(AddResult status, TextBox textBox)
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
            var type = (VariableType) cbType.SelectedItem;
            var status = _knowledgeBase.AddVariable(new Variable(name, type));
            AdditionOutput(status, tbVariable);
        }

        private void dgvVariables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell == null) return;
            tbVariable.Text = _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex].Name;
            cbType.SelectedIndex = (int) _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex].VariableType;
                
            dgvDoman.DataSourceRows = _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex].Domain;
            foreach (DataGridViewColumn column in dgvDoman.Columns)
                column.ReadOnly = true;

        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell != null)
            {
                var name = tbDomain.Text;
                var status = _knowledgeBase.Variables[dgvVariables.CurrentCell.RowIndex].AddDomain(name);
                AdditionOutput(status, tbDomain);
            }
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
        
        private void btnUpdateDomain_Click(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell != null && dgvDoman.CurrentCell != null)
            {
                var name = tbDomain.Text;
                var status = _knowledgeBase
                    .Variables[dgvVariables.CurrentCell.RowIndex]
                    .UpdateDomain(name, dgvDoman.CurrentCell.RowIndex);
                UpdatingOutput(status);
            }
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
            if(dgvVariables.CurrentCell == null || dgvDoman.CurrentCell == null)
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
                    dgvDoman.DataSourceRows = null;
            }
        }

        private void btnUpdateVariable_Click(object sender, EventArgs e)
        {
            if (dgvVariables.CurrentCell != null)
            {
                var name = tbVariable.Text;
                var type = (VariableType) cbType.SelectedItem;
                var status = _knowledgeBase
                    .UpdateVariable(name, type, dgvVariables.CurrentCell.RowIndex);
                UpdatingOutput(status);
            }
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
                tabControl.SelectedIndex = 2;
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
    }
}