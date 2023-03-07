using System.ComponentModel;

namespace Interface
{
    partial class CreateVariable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVariable));
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDomain = new System.Windows.Forms.Label();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.btnDeleteDomain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.containerControl1 = new System.Windows.Forms.ContainerControl();
            this.groupBox1.SuspendLayout();
            this.containerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // lbDomain
            // 
            resources.ApplyResources(this.lbDomain, "lbDomain");
            this.lbDomain.Name = "lbDomain";
            // 
            // tbDomain
            // 
            resources.ApplyResources(this.tbDomain, "tbDomain");
            this.tbDomain.Name = "tbDomain";
            // 
            // btnAddDomain
            // 
            resources.ApplyResources(this.btnAddDomain, "btnAddDomain");
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDomain
            // 
            resources.ApplyResources(this.btnDeleteDomain, "btnDeleteDomain");
            this.btnDeleteDomain.Name = "btnDeleteDomain";
            this.btnDeleteDomain.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.containerControl1);
            this.groupBox1.Controls.Add(this.btnDeleteDomain);
            this.groupBox1.Controls.Add(this.lbDomain);
            this.groupBox1.Controls.Add(this.btnAddDomain);
            this.groupBox1.Controls.Add(this.tbDomain);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // containerControl1
            // 
            this.containerControl1.Controls.Add(this.lbName);
            this.containerControl1.Controls.Add(this.textBox1);
            resources.ApplyResources(this.containerControl1, "containerControl1");
            this.containerControl1.Name = "containerControl1";
            // 
            // CreateVariable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateVariable";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.containerControl1.ResumeLayout(false);
            this.containerControl1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ContainerControl containerControl1;

        private System.Windows.Forms.Label lbDomain;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.Button btnDeleteDomain;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label lbName;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ListView listView1;

        #endregion
    }
}