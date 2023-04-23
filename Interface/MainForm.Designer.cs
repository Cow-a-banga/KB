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
            this.components = new System.ComponentModel.Container();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.rulesTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.variablesTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.containerControl1 = new System.Windows.Forms.ContainerControl();
            this.label5 = new System.Windows.Forms.Label();
            this.lbVariableInRules = new System.Windows.Forms.ListBox();
            this.cbDomain = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateVariable = new System.Windows.Forms.Button();
            this.btnDeleteVariable = new System.Windows.Forms.Button();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbVariable = new System.Windows.Forms.TextBox();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEditDomen = new System.Windows.Forms.Button();
            this.btnDeletDomain = new System.Windows.Forms.Button();
            this.btnAddDomen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.btnEditDomainValue = new System.Windows.Forms.Button();
            this.btnAddDomainValue = new System.Windows.Forms.Button();
            this.btnRemoveDomainValue = new System.Windows.Forms.Button();
            this.tbDomainValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDomainValue = new System.Windows.Forms.DataGridView();
            this.dgvDomain = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tvMemory = new System.Windows.Forms.TreeView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownMenu1 = new System.Windows.Forms.ToolStripDropDownMenu();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.dgvRules)).BeginInit();
            this.tabControl.SuspendLayout();
            this.rulesTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.variablesTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.containerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvVariables)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDomainValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDomain)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.toolStripDropDownMenu1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRules.Location = new System.Drawing.Point(3, 3);
            this.dgvRules.MultiSelect = false;
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.ReadOnly = true;
            this.dgvRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRules.Size = new System.Drawing.Size(786, 394);
            this.dgvRules.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.rulesTab);
            this.tabControl.Controls.Add(this.variablesTab);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 426);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // rulesTab
            // 
            this.rulesTab.Controls.Add(this.groupBox2);
            this.rulesTab.Controls.Add(this.dgvRules);
            this.rulesTab.Location = new System.Drawing.Point(4, 22);
            this.rulesTab.Name = "rulesTab";
            this.rulesTab.Padding = new System.Windows.Forms.Padding(3);
            this.rulesTab.Size = new System.Drawing.Size(792, 400);
            this.rulesTab.TabIndex = 0;
            this.rulesTab.Text = "Правила";
            this.rulesTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(369, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 394);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditRule);
            this.groupBox1.Controls.Add(this.btnDeleteRule);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnEditRule
            // 
            this.btnEditRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRule.Location = new System.Drawing.Point(3, 47);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(408, 25);
            this.btnEditRule.TabIndex = 2;
            this.btnEditRule.Text = "Изменить";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteRule.Location = new System.Drawing.Point(3, 72);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(408, 34);
            this.btnDeleteRule.TabIndex = 1;
            this.btnDeleteRule.Text = "Удалить";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(3, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(408, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // variablesTab
            // 
            this.variablesTab.Controls.Add(this.groupBox3);
            this.variablesTab.Controls.Add(this.dgvVariables);
            this.variablesTab.Location = new System.Drawing.Point(4, 22);
            this.variablesTab.Name = "variablesTab";
            this.variablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.variablesTab.Size = new System.Drawing.Size(792, 400);
            this.variablesTab.TabIndex = 1;
            this.variablesTab.Text = "Переменные";
            this.variablesTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.containerControl1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(364, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 394);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // containerControl1
            // 
            this.containerControl1.Controls.Add(this.label5);
            this.containerControl1.Controls.Add(this.lbVariableInRules);
            this.containerControl1.Controls.Add(this.cbDomain);
            this.containerControl1.Controls.Add(this.label4);
            this.containerControl1.Controls.Add(this.cbType);
            this.containerControl1.Controls.Add(this.label3);
            this.containerControl1.Controls.Add(this.btnUpdateVariable);
            this.containerControl1.Controls.Add(this.btnDeleteVariable);
            this.containerControl1.Controls.Add(this.btnAddVariable);
            this.containerControl1.Controls.Add(this.lbName);
            this.containerControl1.Controls.Add(this.tbVariable);
            this.containerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerControl1.Location = new System.Drawing.Point(3, 16);
            this.containerControl1.Name = "containerControl1";
            this.containerControl1.Size = new System.Drawing.Size(419, 375);
            this.containerControl1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Используется в правилах";
            // 
            // lbVariableInRules
            // 
            this.lbVariableInRules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbVariableInRules.FormattingEnabled = true;
            this.lbVariableInRules.Location = new System.Drawing.Point(0, 228);
            this.lbVariableInRules.Name = "lbVariableInRules";
            this.lbVariableInRules.Size = new System.Drawing.Size(419, 147);
            this.lbVariableInRules.TabIndex = 20;
            // 
            // cbDomain
            // 
            this.cbDomain.FormattingEnabled = true;
            this.cbDomain.Location = new System.Drawing.Point(103, 92);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(171, 21);
            this.cbDomain.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Домен";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(103, 55);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(171, 21);
            this.cbType.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Тип переменной";
            // 
            // btnUpdateVariable
            // 
            this.btnUpdateVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateVariable.Location = new System.Drawing.Point(202, 129);
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
            this.btnDeleteVariable.Location = new System.Drawing.Point(6, 159);
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
            this.btnAddVariable.Location = new System.Drawing.Point(6, 129);
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
            // dgvVariables
            // 
            this.dgvVariables.AllowUserToAddRows = false;
            this.dgvVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVariables.Location = new System.Drawing.Point(3, 3);
            this.dgvVariables.MultiSelect = false;
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.ReadOnly = true;
            this.dgvVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVariables.Size = new System.Drawing.Size(786, 394);
            this.dgvVariables.TabIndex = 0;
            this.dgvVariables.SelectionChanged += new System.EventHandler(this.dgvVariables_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dgvDomain);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 400);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Домены";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.dgvDomainValue);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(397, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 400);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEditDomen);
            this.groupBox5.Controls.Add(this.btnDeletDomain);
            this.groupBox5.Controls.Add(this.btnAddDomen);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.tbDomain);
            this.groupBox5.Controls.Add(this.btnEditDomainValue);
            this.groupBox5.Controls.Add(this.btnAddDomainValue);
            this.groupBox5.Controls.Add(this.btnRemoveDomainValue);
            this.groupBox5.Controls.Add(this.tbDomainValue);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(389, 242);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            // 
            // btnEditDomen
            // 
            this.btnEditDomen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditDomen.Location = new System.Drawing.Point(191, 62);
            this.btnEditDomen.Name = "btnEditDomen";
            this.btnEditDomen.Size = new System.Drawing.Size(192, 24);
            this.btnEditDomen.TabIndex = 26;
            this.btnEditDomen.Text = "Изменить";
            this.btnEditDomen.UseVisualStyleBackColor = true;
            this.btnEditDomen.Click += new System.EventHandler(this.btnUpdateDomain_Click);
            // 
            // btnDeletDomain
            // 
            this.btnDeletDomain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeletDomain.Location = new System.Drawing.Point(6, 92);
            this.btnDeletDomain.Name = "btnDeletDomain";
            this.btnDeletDomain.Size = new System.Drawing.Size(377, 24);
            this.btnDeletDomain.TabIndex = 25;
            this.btnDeletDomain.Text = "Удалить";
            this.btnDeletDomain.UseVisualStyleBackColor = true;
            this.btnDeletDomain.Click += new System.EventHandler(this.btnDeleteDomain_Click);
            // 
            // btnAddDomen
            // 
            this.btnAddDomen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddDomen.Location = new System.Drawing.Point(6, 62);
            this.btnAddDomen.Name = "btnAddDomen";
            this.btnAddDomen.Size = new System.Drawing.Size(180, 24);
            this.btnAddDomen.TabIndex = 24;
            this.btnAddDomen.Text = "Добавить";
            this.btnAddDomen.UseVisualStyleBackColor = true;
            this.btnAddDomen.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // label2
            // 
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Название домена";
            // 
            // tbDomain
            // 
            this.tbDomain.Location = new System.Drawing.Point(6, 36);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(377, 20);
            this.tbDomain.TabIndex = 22;
            // 
            // btnEditDomainValue
            // 
            this.btnEditDomainValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditDomainValue.Location = new System.Drawing.Point(197, 185);
            this.btnEditDomainValue.Name = "btnEditDomainValue";
            this.btnEditDomainValue.Size = new System.Drawing.Size(186, 24);
            this.btnEditDomainValue.TabIndex = 21;
            this.btnEditDomainValue.Text = "Изменить";
            this.btnEditDomainValue.UseVisualStyleBackColor = true;
            this.btnEditDomainValue.Click += new System.EventHandler(this.btnEditDomainValue_Click);
            // 
            // btnAddDomainValue
            // 
            this.btnAddDomainValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddDomainValue.Location = new System.Drawing.Point(6, 185);
            this.btnAddDomainValue.Name = "btnAddDomainValue";
            this.btnAddDomainValue.Size = new System.Drawing.Size(185, 24);
            this.btnAddDomainValue.TabIndex = 19;
            this.btnAddDomainValue.Text = "Добавить";
            this.btnAddDomainValue.UseVisualStyleBackColor = true;
            this.btnAddDomainValue.Click += new System.EventHandler(this.btnAddDomainValue_Click);
            // 
            // btnRemoveDomainValue
            // 
            this.btnRemoveDomainValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveDomainValue.Location = new System.Drawing.Point(6, 214);
            this.btnRemoveDomainValue.Name = "btnRemoveDomainValue";
            this.btnRemoveDomainValue.Size = new System.Drawing.Size(377, 24);
            this.btnRemoveDomainValue.TabIndex = 20;
            this.btnRemoveDomainValue.Text = "Удалить";
            this.btnRemoveDomainValue.UseVisualStyleBackColor = true;
            this.btnRemoveDomainValue.Click += new System.EventHandler(this.btnRemoveDomainValue_Click);
            // 
            // tbDomainValue
            // 
            this.tbDomainValue.Location = new System.Drawing.Point(6, 159);
            this.tbDomainValue.Name = "tbDomainValue";
            this.tbDomainValue.Size = new System.Drawing.Size(377, 20);
            this.tbDomainValue.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название значения";
            // 
            // dgvDomainValue
            // 
            this.dgvDomainValue.AllowDrop = true;
            this.dgvDomainValue.AllowUserToAddRows = false;
            this.dgvDomainValue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDomainValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDomainValue.Location = new System.Drawing.Point(3, 264);
            this.dgvDomainValue.MultiSelect = false;
            this.dgvDomainValue.Name = "dgvDomainValue";
            this.dgvDomainValue.ReadOnly = true;
            this.dgvDomainValue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomainValue.Size = new System.Drawing.Size(389, 133);
            this.dgvDomainValue.TabIndex = 17;
            this.dgvDomainValue.SelectionChanged += new System.EventHandler(this.dgvDomainValue_SelectionChanged);
            // 
            // dgvDomain
            // 
            this.dgvDomain.AllowUserToAddRows = false;
            this.dgvDomain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDomain.Location = new System.Drawing.Point(0, 0);
            this.dgvDomain.MultiSelect = false;
            this.dgvDomain.Name = "dgvDomain";
            this.dgvDomain.ReadOnly = true;
            this.dgvDomain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomain.Size = new System.Drawing.Size(792, 400);
            this.dgvDomain.TabIndex = 0;
            this.dgvDomain.SelectionChanged += new System.EventHandler(this.dgvDomain_SelectionChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvMemory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Дерево";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvMemory
            // 
            this.tvMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMemory.Location = new System.Drawing.Point(3, 3);
            this.tvMemory.Name = "tvMemory";
            this.tvMemory.Size = new System.Drawing.Size(786, 394);
            this.tvMemory.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.открытьToolStripMenuItem, this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // консультацияToolStripMenuItem
            // 
            this.консультацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.начатьToolStripMenuItem});
            this.консультацияToolStripMenuItem.Name = "консультацияToolStripMenuItem";
            this.консультацияToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.консультацияToolStripMenuItem.Text = "Консультация";
            // 
            // начатьToolStripMenuItem
            // 
            this.начатьToolStripMenuItem.Name = "начатьToolStripMenuItem";
            this.начатьToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.начатьToolStripMenuItem.Text = "Начать";
            this.начатьToolStripMenuItem.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // toolStripDropDownMenu1
            // 
            this.toolStripDropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.файлToolStripMenuItem1, this.открытьToolStripMenuItem1});
            this.toolStripDropDownMenu1.Name = "toolStripDropDownMenu1";
            this.toolStripDropDownMenu1.Size = new System.Drawing.Size(122, 48);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.консультацияToolStripMenuItem1, this.начатьToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // консультацияToolStripMenuItem1
            // 
            this.консультацияToolStripMenuItem1.Name = "консультацияToolStripMenuItem1";
            this.консультацияToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.консультацияToolStripMenuItem1.Text = "Консультация";
            // 
            // начатьToolStripMenuItem1
            // 
            this.начатьToolStripMenuItem1.Name = "начатьToolStripMenuItem1";
            this.начатьToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.начатьToolStripMenuItem1.Text = "Начать";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.файлToolStripMenuItem2, this.консультацияToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem2
            // 
            this.файлToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.открытьToolStripMenuItem2, this.сохранитьToolStripMenuItem, this.сохранитьКакToolStripMenuItem1});
            this.файлToolStripMenuItem2.Name = "файлToolStripMenuItem2";
            this.файлToolStripMenuItem2.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem2.Text = "Файл";
            // 
            // открытьToolStripMenuItem2
            // 
            this.открытьToolStripMenuItem2.Name = "открытьToolStripMenuItem2";
            this.открытьToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem2.Text = "Открыть";
            this.открытьToolStripMenuItem2.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem1
            // 
            this.сохранитьКакToolStripMenuItem1.Name = "сохранитьКакToolStripMenuItem1";
            this.сохранитьКакToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem1.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // консультацияToolStripMenuItem2
            // 
            this.консультацияToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.начатьToolStripMenuItem2});
            this.консультацияToolStripMenuItem2.Name = "консультацияToolStripMenuItem2";
            this.консультацияToolStripMenuItem2.Size = new System.Drawing.Size(96, 20);
            this.консультацияToolStripMenuItem2.Text = "Консультация";
            // 
            // начатьToolStripMenuItem2
            // 
            this.начатьToolStripMenuItem2.Name = "начатьToolStripMenuItem2";
            this.начатьToolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.начатьToolStripMenuItem2.Text = "Начать";
            this.начатьToolStripMenuItem2.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize) (this.dgvRules)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.rulesTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.variablesTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.containerControl1.ResumeLayout(false);
            this.containerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvVariables)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDomainValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDomain)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.toolStripDropDownMenu1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lbVariableInRules;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox tbDomainValue;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnEditDomainValue;

        private System.Windows.Forms.Button btnRemoveDomainValue;

        private System.Windows.Forms.Button btnAddDomainValue;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.DataGridView dgvDomainValue;

        private System.Windows.Forms.DataGridView dgvDomain;

        private System.Windows.Forms.Button btnDeletDomain;

        private System.Windows.Forms.Button btnEditDomen;

        private System.Windows.Forms.Button btnAddDomen;

        private System.Windows.Forms.ComboBox cbDomain;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox5;

        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;

        private System.Windows.Forms.ToolStripDropDownMenu toolStripDropDownMenu1;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.ComboBox cbType;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TreeView tvMemory;

        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.Button btnEditRule;

        private System.Windows.Forms.Button btnDeleteRule;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;

        private System.Windows.Forms.Button btnUpdateVariable;
        private System.Windows.Forms.Button btnUpdateDomain;

        private System.Windows.Forms.Button btnDeleteVariable;
        private System.Windows.Forms.Button btnAddVariable;

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

        private System.Windows.Forms.FontDialog fontDialog1;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage rulesTab;
        private System.Windows.Forms.TabPage variablesTab;

        private System.Windows.Forms.DataGridView dgvVariables;

        #endregion
    }
}