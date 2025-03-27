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
            this.csapatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gavallérokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virággyüjtőkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csokornakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szállítaniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.átültetniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focistákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magyarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.külföldiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.készítőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tervezőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kivitelezőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.előadóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csapatokToolStripMenuItem,
            this.készítőToolStripMenuItem,
            this.kilépToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // csapatokToolStripMenuItem
            // 
            this.csapatokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gavallérokToolStripMenuItem,
            this.virággyüjtőkToolStripMenuItem,
            this.focistákToolStripMenuItem});
            this.csapatokToolStripMenuItem.Name = "csapatokToolStripMenuItem";
            this.csapatokToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.csapatokToolStripMenuItem.Text = "Csapatok";
            // 
            // gavallérokToolStripMenuItem
            // 
            this.gavallérokToolStripMenuItem.Name = "gavallérokToolStripMenuItem";
            this.gavallérokToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gavallérokToolStripMenuItem.Text = "Gavallérok";
            this.gavallérokToolStripMenuItem.Click += new System.EventHandler(this.TeamsClick);
            // 
            // virággyüjtőkToolStripMenuItem
            // 
            this.virággyüjtőkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csokornakToolStripMenuItem,
            this.szállítaniToolStripMenuItem,
            this.átültetniToolStripMenuItem});
            this.virággyüjtőkToolStripMenuItem.Name = "virággyüjtőkToolStripMenuItem";
            this.virággyüjtőkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.virággyüjtőkToolStripMenuItem.Text = "Virággyüjtők";
            // 
            // csokornakToolStripMenuItem
            // 
            this.csokornakToolStripMenuItem.Name = "csokornakToolStripMenuItem";
            this.csokornakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.csokornakToolStripMenuItem.Text = "Csokornak";
            this.csokornakToolStripMenuItem.Click += new System.EventHandler(this.TeamsClick);
            // 
            // szállítaniToolStripMenuItem
            // 
            this.szállítaniToolStripMenuItem.Name = "szállítaniToolStripMenuItem";
            this.szállítaniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szállítaniToolStripMenuItem.Text = "Szárítani";
            this.szállítaniToolStripMenuItem.Click += new System.EventHandler(this.TeamsClick);
            // 
            // átültetniToolStripMenuItem
            // 
            this.átültetniToolStripMenuItem.Name = "átültetniToolStripMenuItem";
            this.átültetniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.átültetniToolStripMenuItem.Text = "Átültetni";
            this.átültetniToolStripMenuItem.Click += new System.EventHandler(this.TeamsClick);
            // 
            // focistákToolStripMenuItem
            // 
            this.focistákToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magyarToolStripMenuItem,
            this.külföldiToolStripMenuItem});
            this.focistákToolStripMenuItem.Name = "focistákToolStripMenuItem";
            this.focistákToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.focistákToolStripMenuItem.Text = "Focisták";
            // 
            // magyarToolStripMenuItem
            // 
            this.magyarToolStripMenuItem.Name = "magyarToolStripMenuItem";
            this.magyarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.magyarToolStripMenuItem.Text = "Magyar";
            this.magyarToolStripMenuItem.Click += new System.EventHandler(this.TeamsClick);
            // 
            // külföldiToolStripMenuItem
            // 
            this.külföldiToolStripMenuItem.Name = "külföldiToolStripMenuItem";
            this.külföldiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.külföldiToolStripMenuItem.Text = "Külföldi";
            this.külföldiToolStripMenuItem.Click += new System.EventHandler(this.TeamsClick);
            // 
            // készítőToolStripMenuItem
            // 
            this.készítőToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tervezőToolStripMenuItem,
            this.kivitelezőToolStripMenuItem,
            this.előadóToolStripMenuItem});
            this.készítőToolStripMenuItem.Name = "készítőToolStripMenuItem";
            this.készítőToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.készítőToolStripMenuItem.Text = "Készítő";
            // 
            // tervezőToolStripMenuItem
            // 
            this.tervezőToolStripMenuItem.Name = "tervezőToolStripMenuItem";
            this.tervezőToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tervezőToolStripMenuItem.Text = "Tervező";
            this.tervezőToolStripMenuItem.Click += new System.EventHandler(this.CreatorClick);
            // 
            // kivitelezőToolStripMenuItem
            // 
            this.kivitelezőToolStripMenuItem.Name = "kivitelezőToolStripMenuItem";
            this.kivitelezőToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kivitelezőToolStripMenuItem.Text = "Kivitelező";
            this.kivitelezőToolStripMenuItem.Click += new System.EventHandler(this.CreatorClick);
            // 
            // előadóToolStripMenuItem
            // 
            this.előadóToolStripMenuItem.Name = "előadóToolStripMenuItem";
            this.előadóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.előadóToolStripMenuItem.Text = "Előadó";
            this.előadóToolStripMenuItem.Click += new System.EventHandler(this.CreatorClick);
            // 
            // kilépToolStripMenuItem
            // 
            this.kilépToolStripMenuItem.Name = "kilépToolStripMenuItem";
            this.kilépToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.kilépToolStripMenuItem.Text = "Kilép";
            this.kilépToolStripMenuItem.Click += new System.EventHandler(this.ExitClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 288);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csapatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gavallérokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virággyüjtőkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem focistákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magyarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem készítőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csokornakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szállítaniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem átültetniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tervezőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kivitelezőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem előadóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem külföldiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

