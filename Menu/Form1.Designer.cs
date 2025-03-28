namespace Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.képBeolvasásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pB = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.képBeolvasásaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // képBeolvasásaToolStripMenuItem
            // 
            this.képBeolvasásaToolStripMenuItem.Name = "képBeolvasásaToolStripMenuItem";
            this.képBeolvasásaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.képBeolvasásaToolStripMenuItem.Text = "Kép beolvasása";
            this.képBeolvasásaToolStripMenuItem.Click += new System.EventHandler(this.AddImage);
            // 
            // pB
            // 
            this.pB.Location = new System.Drawing.Point(12, 288);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(150, 150);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB.TabIndex = 1;
            this.pB.TabStop = false;
            this.pB.Click += new System.EventHandler(this.pB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem képBeolvasásaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pB;
    }
}

