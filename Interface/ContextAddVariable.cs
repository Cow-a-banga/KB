using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using KB.Models;
using Model;
using Model.Models;

namespace Interface
{
    public partial class ContextAddVariable : Form
    {
        private KnowledgeBase _kb;

        public ContextAddVariable(KnowledgeBase kb)
        {
            _kb = kb;
            InitializeComponent();
            cbDomain.DataSource = _kb.Domains;
            cbVariable.DataSource = _kb.Variables;
            cbType.DataSource = Enum.GetValues(typeof(VariableType));
        }

        private void cbVariable_TextChanged(object sender, EventArgs e)
        {
            var variableName = cbVariable.Text;
            var variable = _kb.Variables.FirstOrDefault(x => x.Name == variableName);
            if (variable != null)
            {
                var domain = _kb.Domains.FirstOrDefault(x => x.Name == variable.Domain);
                cbDomain.Text = domain.Name;
                cbDomain.Enabled = false;
                dgvDomainValues.DataSource = domain.Values;
                cbType.SelectedIndex = (int) variable.VariableType;
                cbType.Enabled = false;
            }
            else
            {
                cbDomain.Text = string.Empty;
                cbDomain.Enabled = true;
                dgvDomainValues.DataSource = null;
                cbType.Enabled = true;
            }
        }

        private void cbDomain_TextChanged(object sender, EventArgs e)
        {
            var domainName = cbDomain.Text;
            var domain = _kb.Domains.FirstOrDefault(x => x.Name == domainName);
            if (domain != null)
            {
                dgvDomainValues.DataSource = domain.Values;
            }
            else
            {
                dgvDomainValues.DataSource = null;
            }
        }

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            var domainName = cbDomain.Text;
            var domainValue = tbDomainValue.Text;

            if (string.IsNullOrWhiteSpace(domainName) || string.IsNullOrWhiteSpace(domainValue))
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            
            var domain = _kb.Domains.FirstOrDefault(x => x.Name == domainName);
            var value = new DomainValue(domainValue);
            if (domain != null)
            {
                domain.Values.Add(value);
            }
            else
            {
                domain = new Domain {Name = domainName, Values = new BindingList<DomainValue> {value}};
                _kb.Domains.Add(domain);
                dgvDomainValues.DataSource = domain.Values;
            }

            cbDomain.Text = domainName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var variableName = cbVariable.Text;
            var domainName = cbDomain.Text;
            
            if (string.IsNullOrWhiteSpace(domainName) || string.IsNullOrWhiteSpace(variableName))
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            
            var variable = _kb.Variables.FirstOrDefault(x => x.Name == variableName);
            if (variable == null)
            {
                var type = (VariableType) cbType.SelectedIndex;
                
                var domain = _kb.Domains.FirstOrDefault(x => x.Name == domainName);
                if (domain == null)
                {
                    _kb.Domains.Add(new Domain{Name = domainName});
                }
                variable = new Variable(variableName, domainName, type);
                _kb.Variables.Add(variable);
            }
            Close();
        }
    }
}