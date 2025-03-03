namespace Autó_gyakorló
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
            this.carsCb = new System.Windows.Forms.ComboBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.randomizeBtn = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gB = new System.Windows.Forms.GroupBox();
            this.pB = new System.Windows.Forms.PictureBox();
            this.quessTb = new System.Windows.Forms.TextBox();
            this.gB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // carsCb
            // 
            this.carsCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carsCb.FormattingEnabled = true;
            this.carsCb.Location = new System.Drawing.Point(203, 32);
            this.carsCb.Name = "carsCb";
            this.carsCb.Size = new System.Drawing.Size(121, 21);
            this.carsCb.TabIndex = 0;
            this.carsCb.Visible = false;
            this.carsCb.SelectedIndexChanged += new System.EventHandler(this.carsCb_SelectedIndexChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(340, 30);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Következő";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Visible = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.Location = new System.Drawing.Point(421, 30);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(75, 23);
            this.randomizeBtn.TabIndex = 2;
            this.randomizeBtn.Text = "Randomizál";
            this.randomizeBtn.UseVisualStyleBackColor = true;
            this.randomizeBtn.Visible = false;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Pontgyűjtés";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Gyakorlás";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // gB
            // 
            this.gB.Controls.Add(this.radioButton1);
            this.gB.Controls.Add(this.radioButton2);
            this.gB.Location = new System.Drawing.Point(27, 24);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(126, 100);
            this.gB.TabIndex = 5;
            this.gB.TabStop = false;
            // 
            // pB
            // 
            this.pB.Location = new System.Drawing.Point(541, 97);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(200, 200);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB.TabIndex = 6;
            this.pB.TabStop = false;
            this.pB.Visible = false;
            // 
            // quessTb
            // 
            this.quessTb.Location = new System.Drawing.Point(541, 327);
            this.quessTb.Name = "quessTb";
            this.quessTb.Size = new System.Drawing.Size(120, 20);
            this.quessTb.TabIndex = 7;
            this.quessTb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quessTb);
            this.Controls.Add(this.pB);
            this.Controls.Add(this.gB);
            this.Controls.Add(this.randomizeBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.carsCb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gB.ResumeLayout(false);
            this.gB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox carsCb;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button randomizeBtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gB;
        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.TextBox quessTb;
    }
}

