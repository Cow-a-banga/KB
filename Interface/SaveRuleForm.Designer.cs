using System.ComponentModel;

namespace Interface
{
    partial class SaveRuleForm
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
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbVar = new System.Windows.Forms.ComboBox();
            this.lbCondition = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.lVar = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lResValue = new System.Windows.Forms.Label();
            this.cbResValue = new System.Windows.Forms.ComboBox();
            this.lResVar = new System.Windows.Forms.Label();
            this.cbResVar = new System.Windows.Forms.ComboBox();
            this.dgvConditions = new System.Windows.Forms.DataGridView();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.button1);
            this.gbControls.Controls.Add(this.label2);
            this.gbControls.Controls.Add(this.label1);
            this.gbControls.Controls.Add(this.tbDescription);
            this.gbControls.Controls.Add(this.tbName);
            this.gbControls.Controls.Add(this.btnSave);
            this.gbControls.Controls.Add(this.cbVar);
            this.gbControls.Controls.Add(this.lbCondition);
            this.gbControls.Controls.Add(this.lValue);
            this.gbControls.Controls.Add(this.cbValue);
            this.gbControls.Controls.Add(this.lVar);
            this.gbControls.Controls.Add(this.btnDelete);
            this.gbControls.Controls.Add(this.btnAdd);
            this.gbControls.Controls.Add(this.lResValue);
            this.gbControls.Controls.Add(this.cbResValue);
            this.gbControls.Controls.Add(this.lResVar);
            this.gbControls.Controls.Add(this.cbResVar);
            this.gbControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbControls.Location = new System.Drawing.Point(0, 0);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(402, 379);
            this.gbControls.TabIndex = 0;
            this.gbControls.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить переменную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(128, 87);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(227, 20);
            this.tbDescription.TabIndex = 15;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(128, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(227, 20);
            this.tbName.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 24);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbVar
            // 
            this.cbVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVar.FormattingEnabled = true;
            this.cbVar.Location = new System.Drawing.Point(27, 244);
            this.cbVar.Name = "cbVar";
            this.cbVar.Size = new System.Drawing.Size(149, 21);
            this.cbVar.TabIndex = 12;
            this.cbVar.SelectedIndexChanged += new System.EventHandler(this.cbVar_SelectedIndexChanged);
            // 
            // lbCondition
            // 
            this.lbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lbCondition.Location = new System.Drawing.Point(27, 185);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(384, 23);
            this.lbCondition.TabIndex = 11;
            this.lbCondition.Text = "Условие";
            this.lbCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lValue
            // 
            this.lValue.Location = new System.Drawing.Point(206, 218);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(99, 23);
            this.lValue.TabIndex = 10;
            this.lValue.Text = "Значение";
            // 
            // cbValue
            // 
            this.cbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(206, 244);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(149, 21);
            this.cbValue.TabIndex = 9;
            // 
            // lVar
            // 
            this.lVar.Location = new System.Drawing.Point(27, 218);
            this.lVar.Name = "lVar";
            this.lVar.Size = new System.Drawing.Size(99, 23);
            this.lVar.TabIndex = 8;
            this.lVar.Text = "Переменная";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(206, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 24);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 24);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lResValue
            // 
            this.lResValue.Location = new System.Drawing.Point(206, 123);
            this.lResValue.Name = "lResValue";
            this.lResValue.Size = new System.Drawing.Size(149, 23);
            this.lResValue.TabIndex = 3;
            this.lResValue.Text = "Значение заключения";
            // 
            // cbResValue
            // 
            this.cbResValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResValue.FormattingEnabled = true;
            this.cbResValue.Location = new System.Drawing.Point(206, 149);
            this.cbResValue.Name = "cbResValue";
            this.cbResValue.Size = new System.Drawing.Size(149, 21);
            this.cbResValue.TabIndex = 2;
            // 
            // lResVar
            // 
            this.lResVar.Location = new System.Drawing.Point(27, 123);
            this.lResVar.Name = "lResVar";
            this.lResVar.Size = new System.Drawing.Size(149, 23);
            this.lResVar.TabIndex = 1;
            this.lResVar.Text = "Переменная заключения";
            // 
            // cbResVar
            // 
            this.cbResVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResVar.FormattingEnabled = true;
            this.cbResVar.Location = new System.Drawing.Point(27, 149);
            this.cbResVar.Name = "cbResVar";
            this.cbResVar.Size = new System.Drawing.Size(149, 21);
            this.cbResVar.TabIndex = 0;
            this.cbResVar.SelectedIndexChanged += new System.EventHandler(this.cbResVar_SelectedIndexChanged);
            // 
            // dgvConditions
            // 
            this.dgvConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConditions.Location = new System.Drawing.Point(0, 379);
            this.dgvConditions.Name = "dgvConditions";
            this.dgvConditions.Size = new System.Drawing.Size(402, 194);
            this.dgvConditions.TabIndex = 1;
            // 
            // SaveRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 573);
            this.Controls.Add(this.dgvConditions);
            this.Controls.Add(this.gbControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SaveRuleForm";
            this.Text = "Правило";
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvConditions)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox tbDescription;

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.DataGridView dgvConditions;

        private System.Windows.Forms.Label lbCondition;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Label lResVar;

        private System.Windows.Forms.Label lResValue;

        private System.Windows.Forms.ComboBox cbResValue;

        private System.Windows.Forms.ComboBox cbResVar;

        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.ComboBox cbVar;
        private System.Windows.Forms.Label lVar;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.Button btnAdd;


        #endregion
    }
}