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
            this.infoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GetPath = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PullBtn
            // 
            this.PullBtn.Location = new System.Drawing.Point(337, 147);
            this.PullBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PullBtn.Name = "PullBtn";
            this.PullBtn.Size = new System.Drawing.Size(90, 32);
            this.PullBtn.TabIndex = 0;
            this.PullBtn.TabStop = false;
            this.PullBtn.Text = "Pull";
            this.PullBtn.UseVisualStyleBackColor = true;
            this.PullBtn.Click += new System.EventHandler(this.PullBtn_Click);
            // 
            // PushBtn
            // 
            this.PushBtn.Location = new System.Drawing.Point(158, 147);
            this.PushBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PushBtn.Name = "PushBtn";
            this.PushBtn.Size = new System.Drawing.Size(90, 32);
            this.PushBtn.TabIndex = 1;
            this.PushBtn.TabStop = false;
            this.PushBtn.Text = "Push";
            this.PushBtn.UseVisualStyleBackColor = true;
            this.PushBtn.Click += new System.EventHandler(this.PushBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(9, 26);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 17);
            this.infoLabel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetPath});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GetPath
            // 
            this.GetPath.Name = "GetPath";
            this.GetPath.Size = new System.Drawing.Size(117, 20);
            this.GetPath.Text = "Útvonal megadása";
            this.GetPath.Click += new System.EventHandler(this.GetPath_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(129, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.PushBtn);
            this.Controls.Add(this.PullBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Git";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PullBtn;
        private System.Windows.Forms.Button PushBtn;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GetPath;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

