namespace Nevek
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
            this.namesCb = new System.Windows.Forms.ComboBox();
            this.resultCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.resultBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namesCb
            // 
            this.namesCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.namesCb.FormattingEnabled = true;
            this.namesCb.Location = new System.Drawing.Point(79, 95);
            this.namesCb.Name = "namesCb";
            this.namesCb.Size = new System.Drawing.Size(121, 189);
            this.namesCb.TabIndex = 0;
            // 
            // resultCb
            // 
            this.resultCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.resultCb.FormattingEnabled = true;
            this.resultCb.Location = new System.Drawing.Point(473, 95);
            this.resultCb.Name = "resultCb";
            this.resultCb.Size = new System.Drawing.Size(121, 189);
            this.resultCb.TabIndex = 1;
            this.resultCb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Összes";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(470, 54);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 3;
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(216, 49);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(75, 23);
            this.readFileBtn.TabIndex = 4;
            this.readFileBtn.Text = "Beolvasás";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.Location = new System.Drawing.Point(623, 49);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(75, 23);
            this.resultBtn.TabIndex = 5;
            this.resultBtn.Text = "Előfordulás";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultCb);
            this.Controls.Add(this.namesCb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox namesCb;
        private System.Windows.Forms.ComboBox resultCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Button resultBtn;
    }
}

