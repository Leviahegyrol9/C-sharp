namespace extramuszak
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
            this.fájlnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.everyoneCb = new System.Windows.Forms.ComboBox();
            this.daysCb = new System.Windows.Forms.ComboBox();
            this.chosenCb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlnyitásToolStripMenuItem,
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlnyitásToolStripMenuItem
            // 
            this.fájlnyitásToolStripMenuItem.Name = "fájlnyitásToolStripMenuItem";
            this.fájlnyitásToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.fájlnyitásToolStripMenuItem.Text = "Fájlnyitás";
            this.fájlnyitásToolStripMenuItem.Click += new System.EventHandler(this.openFileMenu);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.contactMenu);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(209, 20);
            this.statusLabel.Text = "Válasszon feldolgozandó fájlt!";
            // 
            // everyoneCb
            // 
            this.everyoneCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.everyoneCb.FormattingEnabled = true;
            this.everyoneCb.Location = new System.Drawing.Point(24, 87);
            this.everyoneCb.Name = "everyoneCb";
            this.everyoneCb.Size = new System.Drawing.Size(156, 150);
            this.everyoneCb.Sorted = true;
            this.everyoneCb.TabIndex = 2;
            // 
            // daysCb
            // 
            this.daysCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.daysCb.FormattingEnabled = true;
            this.daysCb.Location = new System.Drawing.Point(238, 87);
            this.daysCb.Name = "daysCb";
            this.daysCb.Size = new System.Drawing.Size(136, 150);
            this.daysCb.TabIndex = 3;
            this.daysCb.SelectedIndexChanged += new System.EventHandler(this.daysCb_SelectedIndexChanged);
            // 
            // chosenCb
            // 
            this.chosenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.chosenCb.FormattingEnabled = true;
            this.chosenCb.Location = new System.Drawing.Point(432, 87);
            this.chosenCb.Name = "chosenCb";
            this.chosenCb.Size = new System.Drawing.Size(136, 150);
            this.chosenCb.TabIndex = 4;
            this.chosenCb.SelectedIndexChanged += new System.EventHandler(this.chosenCb_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(625, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chosenCb);
            this.Controls.Add(this.daysCb);
            this.Controls.Add(this.everyoneCb);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Extra műszak";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem fájlnyitásToolStripMenuItem;
        private System.Windows.Forms.ComboBox everyoneCb;
        private System.Windows.Forms.ComboBox daysCb;
        private System.Windows.Forms.ComboBox chosenCb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

