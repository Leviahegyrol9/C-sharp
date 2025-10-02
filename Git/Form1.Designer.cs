namespace Git
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
            this.PullBtn = new System.Windows.Forms.Button();
            this.PushBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PullBtn
            // 
            this.PullBtn.Location = new System.Drawing.Point(224, 181);
            this.PullBtn.Name = "PullBtn";
            this.PullBtn.Size = new System.Drawing.Size(120, 40);
            this.PullBtn.TabIndex = 0;
            this.PullBtn.Text = "Pull";
            this.PullBtn.UseVisualStyleBackColor = true;
            this.PullBtn.Click += new System.EventHandler(this.PullBtn_Click);
            // 
            // PushBtn
            // 
            this.PushBtn.Location = new System.Drawing.Point(436, 181);
            this.PushBtn.Name = "PushBtn";
            this.PushBtn.Size = new System.Drawing.Size(120, 40);
            this.PushBtn.TabIndex = 1;
            this.PushBtn.Text = "Push";
            this.PushBtn.UseVisualStyleBackColor = true;
            this.PushBtn.Click += new System.EventHandler(this.PushBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PushBtn);
            this.Controls.Add(this.PullBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PullBtn;
        private System.Windows.Forms.Button PushBtn;
    }
}

