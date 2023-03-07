namespace Interface
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.rulesTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.variablesTab = new System.Windows.Forms.TabPage();
            this.dgvDoman = new System.Windows.Forms.DataGridView();
            this.containerControl1 = new System.Windows.Forms.ContainerControl();
            this.btnUpdateDomain = new System.Windows.Forms.Button();
            this.btnUpdateVariable = new System.Windows.Forms.Button();
            this.btnDeleteVariable = new System.Windows.Forms.Button();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbVariable = new System.Windows.Forms.TextBox();
            this.btnDeleteDomain = new System.Windows.Forms.Button();
            this.lbDomain = new System.Windows.Forms.Label();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize) (this.dgvRules)).BeginInit();
            this.tabControl.SuspendLayout();
            this.rulesTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.variablesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDoman)).BeginInit();
            this.containerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRules
            // 
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvRules.Location = new System.Drawing.Point(3, 3);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.Size = new System.Drawing.Size(360, 418);
            this.dgvRules.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.rulesTab);
            this.tabControl.Controls.Add(this.variablesTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 3;
            // 
            // rulesTab
            // 
            this.rulesTab.Controls.Add(this.groupBox3);
            this.rulesTab.Controls.Add(this.groupBox2);
            this.rulesTab.Controls.Add(this.groupBox1);
            this.rulesTab.Controls.Add(this.dgvRules);
            this.rulesTab.Location = new System.Drawing.Point(4, 22);
            this.rulesTab.Name = "rulesTab";
            this.rulesTab.Padding = new System.Windows.Forms.Padding(3);
            this.rulesTab.Size = new System.Drawing.Size(792, 424);
            this.rulesTab.TabIndex = 0;
            this.rulesTab.Text = "Правила";
            this.rulesTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(363, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 148);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(363, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 161);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 142);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(363, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(420, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(3, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(420, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(3, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(420, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // variablesTab
            // 
            this.variablesTab.Controls.Add(this.dgvDoman);
            this.variablesTab.Controls.Add(this.containerControl1);
            this.variablesTab.Controls.Add(this.dgvVariables);
            this.variablesTab.Location = new System.Drawing.Point(4, 22);
            this.variablesTab.Name = "variablesTab";
            this.variablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.variablesTab.Size = new System.Drawing.Size(792, 424);
            this.variablesTab.TabIndex = 1;
            this.variablesTab.Text = "Переменные";
            this.variablesTab.UseVisualStyleBackColor = true;
            // 
            // dgvDoman
            // 
            this.dgvDoman.AllowDrop = true;
            this.dgvDoman.AllowUserToAddRows = false;
            this.dgvDoman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoman.Location = new System.Drawing.Point(390, 245);
            this.dgvDoman.MultiSelect = false;
            this.dgvDoman.Name = "dgvDoman";
            this.dgvDoman.ReadOnly = true;
            this.dgvDoman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoman.Size = new System.Drawing.Size(399, 176);
            this.dgvDoman.TabIndex = 8;
            this.dgvDoman.SelectionChanged += new System.EventHandler(this.dgvDoman_SelectionChanged);
            // 
            // containerControl1
            // 
            this.containerControl1.Controls.Add(this.btnUpdateDomain);
            this.containerControl1.Controls.Add(this.btnUpdateVariable);
            this.containerControl1.Controls.Add(this.btnDeleteVariable);
            this.containerControl1.Controls.Add(this.btnAddVariable);
            this.containerControl1.Controls.Add(this.lbName);
            this.containerControl1.Controls.Add(this.tbVariable);
            this.containerControl1.Controls.Add(this.btnDeleteDomain);
            this.containerControl1.Controls.Add(this.lbDomain);
            this.containerControl1.Controls.Add(this.btnAddDomain);
            this.containerControl1.Controls.Add(this.tbDomain);
            this.containerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.containerControl1.Location = new System.Drawing.Point(390, 3);
            this.containerControl1.Name = "containerControl1";
            this.containerControl1.Size = new System.Drawing.Size(399, 242);
            this.containerControl1.TabIndex = 7;
            this.containerControl1.Text = "containerControl1";
            // 
            // btnUpdateDomain
            // 
            this.btnUpdateDomain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateDomain.Location = new System.Drawing.Point(202, 167);
            this.btnUpdateDomain.Name = "btnUpdateDomain";
            this.btnUpdateDomain.Size = new System.Drawing.Size(192, 24);
            this.btnUpdateDomain.TabIndex = 15;
            this.btnUpdateDomain.Text = "Изменить";
            this.btnUpdateDomain.UseVisualStyleBackColor = true;
            this.btnUpdateDomain.Click += new System.EventHandler(this.btnUpdateDomain_Click);
            // 
            // btnUpdateVariable
            // 
            this.btnUpdateVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateVariable.Location = new System.Drawing.Point(202, 58);
            this.btnUpdateVariable.Name = "btnUpdateVariable";
            this.btnUpdateVariable.Size = new System.Drawing.Size(192, 24);
            this.btnUpdateVariable.TabIndex = 14;
            this.btnUpdateVariable.Text = "Изменить";
            this.btnUpdateVariable.UseVisualStyleBackColor = true;
            this.btnUpdateVariable.Click += new System.EventHandler(this.btnUpdateVariable_Click);
            // 
            // btnDeleteVariable
            // 
            this.btnDeleteVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteVariable.Location = new System.Drawing.Point(6, 87);
            this.btnDeleteVariable.Name = "btnDeleteVariable";
            this.btnDeleteVariable.Size = new System.Drawing.Size(388, 24);
            this.btnDeleteVariable.TabIndex = 13;
            this.btnDeleteVariable.Text = "Удалить";
            this.btnDeleteVariable.UseVisualStyleBackColor = true;
            this.btnDeleteVariable.Click += new System.EventHandler(this.btnDeleteVariable_Click);
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddVariable.Location = new System.Drawing.Point(6, 58);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(190, 24);
            this.btnAddVariable.TabIndex = 12;
            this.btnAddVariable.Text = "Добавить";
            this.btnAddVariable.UseVisualStyleBackColor = true;
            this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
            // 
            // lbName
            // 
            this.lbName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbName.Location = new System.Drawing.Point(6, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(356, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Название переменной";
            // 
            // tbVariable
            // 
            this.tbVariable.Location = new System.Drawing.Point(6, 32);
            this.tbVariable.Name = "tbVariable";
            this.tbVariable.Size = new System.Drawing.Size(388, 20);
            this.tbVariable.TabIndex = 1;
            // 
            // btnDeleteDomain
            // 
            this.btnDeleteDomain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteDomain.Location = new System.Drawing.Point(6, 196);
            this.btnDeleteDomain.Name = "btnDeleteDomain";
            this.btnDeleteDomain.Size = new System.Drawing.Size(388, 24);
            this.btnDeleteDomain.TabIndex = 11;
            this.btnDeleteDomain.Text = "Удалить";
            this.btnDeleteDomain.UseVisualStyleBackColor = true;
            this.btnDeleteDomain.Click += new System.EventHandler(this.btnDeleteDomain_Click);
            // 
            // lbDomain
            // 
            this.lbDomain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDomain.Location = new System.Drawing.Point(1, 117);
            this.lbDomain.Name = "lbDomain";
            this.lbDomain.Size = new System.Drawing.Size(68, 21);
            this.lbDomain.TabIndex = 9;
            this.lbDomain.Text = "Значение";
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddDomain.Location = new System.Drawing.Point(6, 167);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(190, 24);
            this.btnAddDomain.TabIndex = 10;
            this.btnAddDomain.Text = "Добавить";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // tbDomain
            // 
            this.tbDomain.Location = new System.Drawing.Point(6, 141);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(388, 20);
            this.tbDomain.TabIndex = 8;
            // 
            // dgvVariables
            // 
            this.dgvVariables.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvVariables.Location = new System.Drawing.Point(3, 3);
            this.dgvVariables.MultiSelect = false;
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.ReadOnly = true;
            this.dgvVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVariables.Size = new System.Drawing.Size(387, 418);
            this.dgvVariables.TabIndex = 0;
            this.dgvVariables.SelectionChanged += new System.EventHandler(this.dgvVariables_SelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dgvRules)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.rulesTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.variablesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvDoman)).EndInit();
            this.containerControl1.ResumeLayout(false);
            this.containerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvVariables)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnUpdateVariable;
        private System.Windows.Forms.Button btnUpdateDomain;

        private System.Windows.Forms.Button btnDeleteVariable;
        private System.Windows.Forms.Button btnAddVariable;

        private System.Windows.Forms.DataGridView dgvDoman;

        private System.Windows.Forms.ContainerControl containerControl1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbVariable;
        private System.Windows.Forms.Button btnDeleteDomain;
        private System.Windows.Forms.Label lbDomain;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.TextBox tbDomain;

        private System.Windows.Forms.DataGridView dgvRules;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage rulesTab;
        private System.Windows.Forms.TabPage variablesTab;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DataGridView dgvVariables;

        #endregion
    }
}