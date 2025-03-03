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
            this.pB = new System.Windows.Forms.PictureBox();
            this.guess = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.plusPoint = new System.Windows.Forms.Label();
            this.minusPoint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxPoint = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsCb
            // 
            this.carsCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carsCb.FormattingEnabled = true;
            this.carsCb.Location = new System.Drawing.Point(8, 18);
            this.carsCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carsCb.Name = "carsCb";
            this.carsCb.Size = new System.Drawing.Size(160, 24);
            this.carsCb.TabIndex = 0;
            this.carsCb.Visible = false;
            this.carsCb.SelectedIndexChanged += new System.EventHandler(this.carsCb_SelectedIndexChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(190, 16);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(100, 28);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Következő";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Visible = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.Location = new System.Drawing.Point(298, 16);
            this.randomizeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(100, 28);
            this.randomizeBtn.TabIndex = 2;
            this.randomizeBtn.Text = "Randomizál";
            this.randomizeBtn.UseVisualStyleBackColor = true;
            this.randomizeBtn.Visible = false;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 48);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Pontgyűjtés";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 19);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Gyakorlás";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // pB
            // 
            this.pB.Location = new System.Drawing.Point(765, 30);
            this.pB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(267, 246);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB.TabIndex = 6;
            this.pB.TabStop = false;
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(741, 26);
            this.guess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(159, 22);
            this.guess.TabIndex = 7;
            this.guess.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(50, 65);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(50, 137);
            this.trackBar2.Maximum = 5;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 56);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(438, 153);
            this.trackBar3.Maximum = 20;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 56);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // plusPoint
            // 
            this.plusPoint.AutoSize = true;
            this.plusPoint.Location = new System.Drawing.Point(160, 70);
            this.plusPoint.Name = "plusPoint";
            this.plusPoint.Size = new System.Drawing.Size(14, 16);
            this.plusPoint.TabIndex = 11;
            this.plusPoint.Text = "1";
            // 
            // minusPoint
            // 
            this.minusPoint.AutoSize = true;
            this.minusPoint.Location = new System.Drawing.Point(160, 141);
            this.minusPoint.Name = "minusPoint";
            this.minusPoint.Size = new System.Drawing.Size(14, 16);
            this.minusPoint.TabIndex = 12;
            this.minusPoint.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.carsCb);
            this.panel1.Controls.Add(this.randomizeBtn);
            this.panel1.Location = new System.Drawing.Point(252, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 55);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.points);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.maxPoint);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBtn);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.trackBar3);
            this.panel2.Controls.Add(this.minusPoint);
            this.panel2.Controls.Add(this.guess);
            this.panel2.Controls.Add(this.plusPoint);
            this.panel2.Location = new System.Drawing.Point(36, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 242);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 85);
            this.panel3.TabIndex = 16;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(907, 26);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 13;
            this.checkBtn.Text = "Ellenőriz";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pontok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(339, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Max pont";
            // 
            // maxPoint
            // 
            this.maxPoint.AutoSize = true;
            this.maxPoint.Location = new System.Drawing.Point(548, 157);
            this.maxPoint.Name = "maxPoint";
            this.maxPoint.Size = new System.Drawing.Size(14, 16);
            this.maxPoint.TabIndex = 18;
            this.maxPoint.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(738, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pontszám:";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points.Location = new System.Drawing.Point(815, 71);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(0, 20);
            this.points.TabIndex = 20;
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(30, 115);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(98, 34);
            this.restartBtn.TabIndex = 17;
            this.restartBtn.Text = "Újrakezdés";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Paplukács Levente";
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox carsCb;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button randomizeBtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label plusPoint;
        private System.Windows.Forms.Label minusPoint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button restartBtn;
    }
}

