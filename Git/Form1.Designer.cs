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
            this.commitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PullBtn
            // 
            this.PullBtn.Location = new System.Drawing.Point(449, 181);
            this.PullBtn.Name = "PullBtn";
            this.PullBtn.Size = new System.Drawing.Size(120, 40);
            this.PullBtn.TabIndex = 0;
            this.PullBtn.TabStop = false;
            this.PullBtn.Text = "Pull";
            this.PullBtn.UseVisualStyleBackColor = true;
            this.PullBtn.Click += new System.EventHandler(this.PullBtn_Click);
            // 
            // PushBtn
            // 
            this.PushBtn.Location = new System.Drawing.Point(210, 181);
            this.PushBtn.Name = "PushBtn";
            this.PushBtn.Size = new System.Drawing.Size(120, 40);
            this.PushBtn.TabIndex = 1;
            this.PushBtn.TabStop = false;
            this.PushBtn.Text = "Push";
            this.PushBtn.UseVisualStyleBackColor = true;
            this.PushBtn.Click += new System.EventHandler(this.PushBtn_Click);
            // 
            // commitLabel
            // 
            this.commitLabel.AutoSize = true;
            this.commitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commitLabel.Location = new System.Drawing.Point(12, 9);
            this.commitLabel.Name = "commitLabel";
            this.commitLabel.Size = new System.Drawing.Size(0, 20);
            this.commitLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.commitLabel);
            this.Controls.Add(this.PushBtn);
            this.Controls.Add(this.PullBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Git";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PullBtn;
        private System.Windows.Forms.Button PushBtn;
        private System.Windows.Forms.Label commitLabel;
    }
}

