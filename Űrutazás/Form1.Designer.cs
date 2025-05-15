namespace EmailValidator
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
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ageTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.afterLogin = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.afterLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(107, 99);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email cím:";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(79, 136);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(91, 20);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Bejelentkezés";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Életkor:";
            // 
            // ageTb
            // 
            this.ageTb.Location = new System.Drawing.Point(107, 69);
            this.ageTb.Name = "ageTb";
            this.ageTb.Size = new System.Drawing.Size(100, 20);
            this.ageTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Név:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(107, 43);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 5;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(69, 34);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 20);
            this.fileName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fájl név:";
            // 
            // afterLogin
            // 
            this.afterLogin.Controls.Add(this.saveBtn);
            this.afterLogin.Controls.Add(this.fileName);
            this.afterLogin.Controls.Add(this.label4);
            this.afterLogin.Location = new System.Drawing.Point(257, 12);
            this.afterLogin.Name = "afterLogin";
            this.afterLogin.Size = new System.Drawing.Size(248, 100);
            this.afterLogin.TabIndex = 9;
            this.afterLogin.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(177, 34);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(59, 20);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Mentés";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 10;
            this.statusBar.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.afterLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageTb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Name = "Form1";
            this.Text = "Form1";
            this.afterLogin.ResumeLayout(false);
            this.afterLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel afterLogin;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.StatusStrip statusBar;
    }
}

