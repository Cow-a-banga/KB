using System.ComponentModel;

namespace Interface
{
    partial class ContextAddVariable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDomain = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDomainValues = new System.Windows.Forms.DataGridView();
            this.tbDomainValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbVariable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDomainValues)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(80, 193);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(185, 38);
            this.btnAddValue.TabIndex = 0;
            this.btnAddValue.Text = "Добавить значение";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Переменная";
            // 
            // cbDomain
            // 
            this.cbDomain.FormattingEnabled = true;
            this.cbDomain.Location = new System.Drawing.Point(126, 120);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(168, 21);
            this.cbDomain.TabIndex = 3;
            this.cbDomain.TextChanged += new System.EventHandler(this.cbDomain_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Домен";
            // 
            // dgvDomainValues
            // 
            this.dgvDomainValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomainValues.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDomainValues.Location = new System.Drawing.Point(0, 290);
            this.dgvDomainValues.Name = "dgvDomainValues";
            this.dgvDomainValues.Size = new System.Drawing.Size(341, 160);
            this.dgvDomainValues.TabIndex = 5;
            // 
            // tbDomainValue
            // 
            this.tbDomainValue.Location = new System.Drawing.Point(125, 158);
            this.tbDomainValue.Name = "tbDomainValue";
            this.tbDomainValue.Size = new System.Drawing.Size(169, 20);
            this.tbDomainValue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Значение домена";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(80, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbVariable
            // 
            this.cbVariable.FormattingEnabled = true;
            this.cbVariable.Location = new System.Drawing.Point(126, 48);
            this.cbVariable.Name = "cbVariable";
            this.cbVariable.Size = new System.Drawing.Size(168, 21);
            this.cbVariable.TabIndex = 9;
            this.cbVariable.TextChanged += new System.EventHandler(this.cbVariable_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Тип";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Enabled = false;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(126, 84);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(168, 21);
            this.cbType.TabIndex = 10;
            // 
            // ContextAddVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbVariable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDomainValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDomainValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDomain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddValue);
            this.Name = "ContextAddVariable";
            this.Text = "ContextAddVariable";
            ((System.ComponentModel.ISupportInitialize) (this.dgvDomainValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cbType;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbVariable;

        private System.Windows.Forms.DataGridView dgvDomainValues;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.ComboBox cbDomain;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDomainValue;

        #endregion
    }
}