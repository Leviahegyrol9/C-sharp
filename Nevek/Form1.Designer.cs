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
            this.showDictCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // namesCb
            // 
            this.namesCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.namesCb.FormattingEnabled = true;
            this.namesCb.Location = new System.Drawing.Point(105, 117);
            this.namesCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.namesCb.Name = "namesCb";
            this.namesCb.Size = new System.Drawing.Size(160, 232);
            this.namesCb.TabIndex = 0;
            // 
            // resultCb
            // 
            this.resultCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.resultCb.FormattingEnabled = true;
            this.resultCb.Location = new System.Drawing.Point(541, 117);
            this.resultCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultCb.Name = "resultCb";
            this.resultCb.Size = new System.Drawing.Size(160, 232);
            this.resultCb.Sorted = true;
            this.resultCb.TabIndex = 1;
            this.resultCb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Összes";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(538, 66);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 3;
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(288, 60);
            this.readFileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(100, 28);
            this.readFileBtn.TabIndex = 4;
            this.readFileBtn.Text = "Beolvasás";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.Location = new System.Drawing.Point(722, 60);
            this.resultBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(100, 28);
            this.resultBtn.TabIndex = 5;
            this.resultBtn.Text = "Előfordulás";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // showDictCb
            // 
            this.showDictCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.showDictCb.FormattingEnabled = true;
            this.showDictCb.Location = new System.Drawing.Point(848, 117);
            this.showDictCb.Margin = new System.Windows.Forms.Padding(4);
            this.showDictCb.Name = "showDictCb";
            this.showDictCb.Size = new System.Drawing.Size(160, 232);
            this.showDictCb.TabIndex = 6;
            this.showDictCb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.showDictCb);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultCb);
            this.Controls.Add(this.namesCb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox showDictCb;
    }
}

