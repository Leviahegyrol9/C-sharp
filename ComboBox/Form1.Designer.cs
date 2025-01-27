namespace ComboBox
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
            this.removeBTN = new System.Windows.Forms.Button();
            this.sortBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.writeBTN = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileName2 = new System.Windows.Forms.TextBox();
            this.readBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.ComboBox();
            this.resultText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(55, 115);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(121, 229);
            this.list.TabIndex = 0;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(169, 52);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(39, 22);
            this.addBTN.TabIndex = 1;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(93, 52);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(70, 20);
            this.input.TabIndex = 2;
            // 
            // removeBTN
            // 
            this.removeBTN.Location = new System.Drawing.Point(214, 52);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(60, 22);
            this.removeBTN.TabIndex = 3;
            this.removeBTN.Text = "Remove";
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // sortBTN
            // 
            this.sortBTN.Location = new System.Drawing.Point(200, 115);
            this.sortBTN.Name = "sortBTN";
            this.sortBTN.Size = new System.Drawing.Size(60, 24);
            this.sortBTN.TabIndex = 4;
            this.sortBTN.Text = "Sort";
            this.sortBTN.UseVisualStyleBackColor = true;
            this.sortBTN.Click += new System.EventHandler(this.sortBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // writeBTN
            // 
            this.writeBTN.Location = new System.Drawing.Point(568, 53);
            this.writeBTN.Name = "writeBTN";
            this.writeBTN.Size = new System.Drawing.Size(75, 23);
            this.writeBTN.TabIndex = 6;
            this.writeBTN.Text = "Write";
            this.writeBTN.UseVisualStyleBackColor = true;
            this.writeBTN.Click += new System.EventHandler(this.writeBTN_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(480, 54);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(82, 20);
            this.fileName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(405, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "File name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(405, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "File name:";
            // 
            // fileName2
            // 
            this.fileName2.Location = new System.Drawing.Point(480, 161);
            this.fileName2.Name = "fileName2";
            this.fileName2.Size = new System.Drawing.Size(82, 20);
            this.fileName2.TabIndex = 10;
            // 
            // readBTN
            // 
            this.readBTN.Location = new System.Drawing.Point(568, 160);
            this.readBTN.Name = "readBTN";
            this.readBTN.Size = new System.Drawing.Size(75, 23);
            this.readBTN.TabIndex = 9;
            this.readBTN.Text = "Read";
            this.readBTN.UseVisualStyleBackColor = true;
            this.readBTN.Click += new System.EventHandler(this.readBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(348, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Write:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(348, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Read:";
            // 
            // result
            // 
            this.result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.result.FormattingEnabled = true;
            this.result.Location = new System.Drawing.Point(408, 222);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(121, 202);
            this.result.TabIndex = 14;
            this.result.Visible = false;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(568, 222);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 13);
            this.resultText.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileName2);
            this.Controls.Add(this.readBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.writeBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortBTN);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.input);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.list);
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
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Button sortBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button writeBTN;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileName2;
        private System.Windows.Forms.Button readBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox result;
        private System.Windows.Forms.Label resultText;
    }
}

