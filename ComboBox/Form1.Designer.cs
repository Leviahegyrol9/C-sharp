namespace ComboBoxFeladat
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
            this.list = new System.Windows.Forms.ComboBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.writeBTN = new System.Windows.Forms.Button();
            this.readBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.topBirdsBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(73, 142);
            this.list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(160, 281);
            this.list.TabIndex = 0;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(225, 64);
            this.addBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(52, 27);
            this.addBTN.TabIndex = 1;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(124, 64);
            this.input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(92, 22);
            this.input.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bird name:";
            // 
            // writeBTN
            // 
            this.writeBTN.Location = new System.Drawing.Point(521, 58);
            this.writeBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.writeBTN.Name = "writeBTN";
            this.writeBTN.Size = new System.Drawing.Size(100, 28);
            this.writeBTN.TabIndex = 6;
            this.writeBTN.Text = "Write";
            this.writeBTN.UseVisualStyleBackColor = true;
            this.writeBTN.Click += new System.EventHandler(this.writeBTN_Click);
            // 
            // readBTN
            // 
            this.readBTN.Location = new System.Drawing.Point(680, 58);
            this.readBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readBTN.Name = "readBTN";
            this.readBTN.Size = new System.Drawing.Size(100, 28);
            this.readBTN.TabIndex = 9;
            this.readBTN.Text = "Read";
            this.readBTN.UseVisualStyleBackColor = true;
            this.readBTN.Click += new System.EventHandler(this.readBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(521, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // topBirdsBtn
            // 
            this.topBirdsBtn.Location = new System.Drawing.Point(813, 255);
            this.topBirdsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topBirdsBtn.Name = "topBirdsBtn";
            this.topBirdsBtn.Size = new System.Drawing.Size(100, 28);
            this.topBirdsBtn.TabIndex = 11;
            this.topBirdsBtn.Text = "Top birds";
            this.topBirdsBtn.UseVisualStyleBackColor = true;
            this.topBirdsBtn.Click += new System.EventHandler(this.topBirdBtn_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(518, 220);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 16);
            this.output.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.output);
            this.Controls.Add(this.topBirdsBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.readBTN);
            this.Controls.Add(this.writeBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.list);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Paplukács Levente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button writeBTN;
        private System.Windows.Forms.Button readBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button topBirdsBtn;
        private System.Windows.Forms.Label output;
    }
}

