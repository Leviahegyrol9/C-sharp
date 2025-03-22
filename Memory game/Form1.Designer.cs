namespace Memory_game
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
            this.optionPanel = new System.Windows.Forms.Panel();
            this.hardRb = new System.Windows.Forms.RadioButton();
            this.easyRb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionPanel
            // 
            this.optionPanel.Controls.Add(this.hardRb);
            this.optionPanel.Controls.Add(this.easyRb);
            this.optionPanel.Location = new System.Drawing.Point(350, 201);
            this.optionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(368, 55);
            this.optionPanel.TabIndex = 0;
            // 
            // hardRb
            // 
            this.hardRb.AutoSize = true;
            this.hardRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hardRb.Location = new System.Drawing.Point(198, 13);
            this.hardRb.Margin = new System.Windows.Forms.Padding(4);
            this.hardRb.Name = "hardRb";
            this.hardRb.Size = new System.Drawing.Size(157, 29);
            this.hardRb.TabIndex = 1;
            this.hardRb.TabStop = true;
            this.hardRb.Tag = "1";
            this.hardRb.Text = "Nehéz (4 kép)";
            this.hardRb.UseVisualStyleBackColor = true;
            // 
            // easyRb
            // 
            this.easyRb.AutoSize = true;
            this.easyRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.easyRb.Location = new System.Drawing.Point(13, 13);
            this.easyRb.Margin = new System.Windows.Forms.Padding(4);
            this.easyRb.Name = "easyRb";
            this.easyRb.Size = new System.Drawing.Size(168, 29);
            this.easyRb.TabIndex = 0;
            this.easyRb.TabStop = true;
            this.easyRb.Tag = "0";
            this.easyRb.Text = "Könnyű (2 kép)";
            this.easyRb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(318, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nehézségi fokozat kiválasztása:";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBtn.Location = new System.Drawing.Point(475, 288);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(137, 42);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Kezdés";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(394, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memória játék";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Válasszon nehézségi fokozatot!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.RadioButton hardRb;
        private System.Windows.Forms.RadioButton easyRb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label2;
    }
}

