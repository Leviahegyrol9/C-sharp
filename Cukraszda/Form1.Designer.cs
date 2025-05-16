namespace Cukraszda
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cakeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(94, 41);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // cakeType
            // 
            this.cakeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cakeType.FormattingEnabled = true;
            this.cakeType.Items.AddRange(new object[] {
            "Csokitorta",
            "Gyümölcstorta",
            "Sajttorta",
            "Mignon"});
            this.cakeType.Location = new System.Drawing.Point(390, 40);
            this.cakeType.Name = "cakeType";
            this.cakeType.Size = new System.Drawing.Size(121, 21);
            this.cakeType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Darabszám:";
            // 
            // countTb
            // 
            this.countTb.Location = new System.Drawing.Point(94, 81);
            this.countTb.Name = "countTb";
            this.countTb.Size = new System.Drawing.Size(100, 20);
            this.countTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(94, 119);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(100, 20);
            this.emailTb.TabIndex = 5;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(76, 169);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 23);
            this.orderBtn.TabIndex = 7;
            this.orderBtn.Text = "Leadás";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sütemény típusa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countTb);
            this.Controls.Add(this.cakeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cakeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label label4;
    }
}

