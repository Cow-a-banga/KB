using System.ComponentModel;

namespace Interface
{
    partial class ConsultForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAnswers = new System.Windows.Forms.ComboBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbQuestion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAnswers);
            this.groupBox2.Controls.Add(this.btnAnswer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cbAnswers
            // 
            this.cbAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAnswers.FormattingEnabled = true;
            this.cbAnswers.Location = new System.Drawing.Point(3, 16);
            this.cbAnswers.Name = "cbAnswers";
            this.cbAnswers.Size = new System.Drawing.Size(353, 21);
            this.cbAnswers.TabIndex = 1;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnswer.Location = new System.Drawing.Point(356, 16);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 26);
            this.btnAnswer.TabIndex = 0;
            this.btnAnswer.Text = "Выбрать";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lbQuestion
            // 
            this.lbQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbQuestion.Location = new System.Drawing.Point(3, 16);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(434, 25);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Вопрос";
            // 
            // lbHistory
            // 
            this.lbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(0, 0);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbHistory.Size = new System.Drawing.Size(440, 251);
            this.lbHistory.TabIndex = 2;
            // 
            // ConsultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsultForm";
            this.Text = "Консультация";
            this.Shown += new System.EventHandler(this.ConsultForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbQuestion;

        private System.Windows.Forms.ComboBox cbAnswers;

        private System.Windows.Forms.Button btnAnswer;

        private System.Windows.Forms.ListBox lbHistory;
        

        private System.Windows.Forms.GroupBox groupBox2;
        

        private System.Windows.Forms.GroupBox groupBox1;
        

        #endregion
    }
}