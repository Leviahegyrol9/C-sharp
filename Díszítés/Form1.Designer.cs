namespace Díszítés
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
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.készítetteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.készítőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wallHeight = new System.Windows.Forms.TextBox();
            this.wallWidth = new System.Windows.Forms.TextBox();
            this.sofaHeight = new System.Windows.Forms.TextBox();
            this.sofaWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.súgóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.készítetteToolStripMenuItem,
            this.készítőToolStripMenuItem});
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // készítetteToolStripMenuItem
            // 
            this.készítetteToolStripMenuItem.Name = "készítetteToolStripMenuItem";
            this.készítetteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.készítetteToolStripMenuItem.Text = "Készült";
            this.készítetteToolStripMenuItem.Click += new System.EventHandler(this.madeMenu);
            // 
            // készítőToolStripMenuItem
            // 
            this.készítőToolStripMenuItem.Name = "készítőToolStripMenuItem";
            this.készítőToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.készítőToolStripMenuItem.Text = "Készítette";
            this.készítőToolStripMenuItem.Click += new System.EventHandler(this.contactMenu);
            // 
            // wallHeight
            // 
            this.wallHeight.Location = new System.Drawing.Point(127, 30);
            this.wallHeight.Name = "wallHeight";
            this.wallHeight.Size = new System.Drawing.Size(100, 20);
            this.wallHeight.TabIndex = 1;
            this.wallHeight.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // wallWidth
            // 
            this.wallWidth.Location = new System.Drawing.Point(127, 78);
            this.wallWidth.Name = "wallWidth";
            this.wallWidth.Size = new System.Drawing.Size(100, 20);
            this.wallWidth.TabIndex = 2;
            this.wallWidth.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // sofaHeight
            // 
            this.sofaHeight.Location = new System.Drawing.Point(127, 122);
            this.sofaHeight.Name = "sofaHeight";
            this.sofaHeight.Size = new System.Drawing.Size(100, 20);
            this.sofaHeight.TabIndex = 3;
            this.sofaHeight.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // sofaWidth
            // 
            this.sofaWidth.Location = new System.Drawing.Point(127, 164);
            this.sofaWidth.Name = "sofaWidth";
            this.sofaWidth.Size = new System.Drawing.Size(100, 20);
            this.sofaWidth.TabIndex = 4;
            this.sofaWidth.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fal hossza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fal magassága:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kanapé hossza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kanapé magassága:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wallWidth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.wallHeight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sofaHeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sofaWidth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 222);
            this.panel1.TabIndex = 9;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(315, 294);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 10;
            this.calculateBtn.Text = "Számol";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Visible = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuBar
            // 
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(0, 17);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(533, 96);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem készítetteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem készítőToolStripMenuItem;
        private System.Windows.Forms.TextBox wallHeight;
        private System.Windows.Forms.TextBox wallWidth;
        private System.Windows.Forms.TextBox sofaHeight;
        private System.Windows.Forms.TextBox sofaWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel menuBar;
        private System.Windows.Forms.Label resultLabel;
    }
}

