namespace Memory_game
{
    partial class Form2
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
            this.currentPb = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imagesCb = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentPb)).BeginInit();
            this.SuspendLayout();
            // 
            // currentPb
            // 
            this.currentPb.Location = new System.Drawing.Point(507, 191);
            this.currentPb.Margin = new System.Windows.Forms.Padding(4);
            this.currentPb.Name = "currentPb";
            this.currentPb.Size = new System.Drawing.Size(200, 185);
            this.currentPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentPb.TabIndex = 4;
            this.currentPb.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(609, 119);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Törlés";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(501, 119);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 28);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Hozzáad";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(325, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Képlista";
            // 
            // imagesCb
            // 
            this.imagesCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.imagesCb.FormattingEnabled = true;
            this.imagesCb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imagesCb.Location = new System.Drawing.Point(328, 154);
            this.imagesCb.Margin = new System.Windows.Forms.Padding(4);
            this.imagesCb.Name = "imagesCb";
            this.imagesCb.Size = new System.Drawing.Size(156, 200);
            this.imagesCb.TabIndex = 0;
            this.imagesCb.SelectedIndexChanged += new System.EventHandler(this.imagesCb_SelectedIndexChanged);
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(449, 406);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(100, 28);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Kezdés";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(418, 26);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 32);
            this.infoLabel.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.currentPb);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.imagesCb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Válassza ki a képeket!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.currentPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox imagesCb;
        private System.Windows.Forms.PictureBox currentPb;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label infoLabel;
    }
}