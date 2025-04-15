namespace ServiceTool
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
            this.git_pull = new System.Windows.Forms.Button();
            this.git_push = new System.Windows.Forms.Button();
            this.win10ContextMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // git_pull
            // 
            this.git_pull.Location = new System.Drawing.Point(23, 39);
            this.git_pull.Name = "git_pull";
            this.git_pull.Size = new System.Drawing.Size(75, 23);
            this.git_pull.TabIndex = 0;
            this.git_pull.Text = "Pull";
            this.git_pull.UseVisualStyleBackColor = true;
            this.git_pull.Click += new System.EventHandler(this.startGitCMD);
            // 
            // git_push
            // 
            this.git_push.Location = new System.Drawing.Point(104, 39);
            this.git_push.Name = "git_push";
            this.git_push.Size = new System.Drawing.Size(75, 23);
            this.git_push.TabIndex = 1;
            this.git_push.Text = "Push";
            this.git_push.UseVisualStyleBackColor = true;
            this.git_push.Click += new System.EventHandler(this.startGitCMD);
            // 
            // win10ContextMenu
            // 
            this.win10ContextMenu.Location = new System.Drawing.Point(12, 228);
            this.win10ContextMenu.Name = "win10ContextMenu";
            this.win10ContextMenu.Size = new System.Drawing.Size(171, 23);
            this.win10ContextMenu.TabIndex = 2;
            this.win10ContextMenu.Text = "Windows 10 context menu";
            this.win10ContextMenu.UseVisualStyleBackColor = true;
            this.win10ContextMenu.Click += new System.EventHandler(this.win10ContextMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.win10ContextMenu);
            this.Controls.Add(this.git_push);
            this.Controls.Add(this.git_pull);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button git_pull;
        private System.Windows.Forms.Button git_push;
        private System.Windows.Forms.Button win10ContextMenu;
    }
}

