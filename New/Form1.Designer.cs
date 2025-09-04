namespace New
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.sexRatioBtn = new System.Windows.Forms.Button();
            this.studentsByClassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 342);
            this.listBox1.TabIndex = 0;
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.Location = new System.Drawing.Point(468, 102);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(208, 25);
            this.loadDataBtn.TabIndex = 1;
            this.loadDataBtn.Text = "Adatok betöltése";
            this.loadDataBtn.UseVisualStyleBackColor = true;
            this.loadDataBtn.Click += new System.EventHandler(this.loadDataBtn_Click);
            // 
            // studentsBtn
            // 
            this.studentsBtn.Location = new System.Drawing.Point(468, 154);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(208, 25);
            this.studentsBtn.TabIndex = 2;
            this.studentsBtn.Text = "9.A osztályos diákok";
            this.studentsBtn.UseVisualStyleBackColor = true;
            this.studentsBtn.Click += new System.EventHandler(this.studentsBtn_Click);
            // 
            // sexRatioBtn
            // 
            this.sexRatioBtn.Location = new System.Drawing.Point(468, 210);
            this.sexRatioBtn.Name = "sexRatioBtn";
            this.sexRatioBtn.Size = new System.Drawing.Size(208, 25);
            this.sexRatioBtn.TabIndex = 3;
            this.sexRatioBtn.Text = "Nemek aránya";
            this.sexRatioBtn.UseVisualStyleBackColor = true;
            this.sexRatioBtn.Click += new System.EventHandler(this.sexRatioBtn_Click);
            // 
            // studentsByClassBtn
            // 
            this.studentsByClassBtn.Location = new System.Drawing.Point(468, 265);
            this.studentsByClassBtn.Name = "studentsByClassBtn";
            this.studentsByClassBtn.Size = new System.Drawing.Size(208, 25);
            this.studentsByClassBtn.TabIndex = 4;
            this.studentsByClassBtn.Text = "Osztályonkénti létszám";
            this.studentsByClassBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentsByClassBtn);
            this.Controls.Add(this.sexRatioBtn);
            this.Controls.Add(this.studentsBtn);
            this.Controls.Add(this.loadDataBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button loadDataBtn;
        private System.Windows.Forms.Button studentsBtn;
        private System.Windows.Forms.Button sexRatioBtn;
        private System.Windows.Forms.Button studentsByClassBtn;
    }
}

