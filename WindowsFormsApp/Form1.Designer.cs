namespace WindowsFormsApp
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.motorHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.CashClear = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.priceBTN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 92);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 43);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.start_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(119, 92);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(79, 43);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Stop";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.end_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(12, 9);
            this.result.MinimumSize = new System.Drawing.Size(100, 25);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 25);
            this.result.TabIndex = 2;
            // 
            // motorHP
            // 
            this.motorHP.Location = new System.Drawing.Point(239, 111);
            this.motorHP.Name = "motorHP";
            this.motorHP.Size = new System.Drawing.Size(45, 22);
            this.motorHP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Motor %";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(60, 159);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(104, 28);
            this.progressBar.TabIndex = 5;
            // 
            // CashClear
            // 
            this.CashClear.Location = new System.Drawing.Point(46, 385);
            this.CashClear.Name = "CashClear";
            this.CashClear.Size = new System.Drawing.Size(79, 43);
            this.CashClear.TabIndex = 6;
            this.CashClear.Text = "Clear";
            this.CashClear.UseVisualStyleBackColor = true;
            this.CashClear.Click += new System.EventHandler(this.CashClear_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Limousine YJH 53",
            "Dodge RAM TRX Reaper 2022 OFFROAD LXW 10",
            "Ford Raptor Scorpion 2017 NGR 84",
            "BMW X7 HCD 72",
            "Mercedes C63 AMG 2012 LIH 21",
            "KTM Cross MDK 63",
            "Kawasaki Ninja ZX6R GIY 62",
            "KTM Cross RZR 64",
            "BMW S-1000 RR PVZ 53",
            "Brabus ML63 GOQ 84",
            "Audi RS5 2011 BJS 32"});
            this.comboBox.Location = new System.Drawing.Point(382, 76);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(114, 24);
            this.comboBox.TabIndex = 7;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(644, 76);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(64, 24);
            this.addBTN.TabIndex = 8;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceBTN
            // 
            this.priceBTN.Location = new System.Drawing.Point(511, 76);
            this.priceBTN.MinimumSize = new System.Drawing.Size(45, 24);
            this.priceBTN.Name = "priceBTN";
            this.priceBTN.Size = new System.Drawing.Size(45, 24);
            this.priceBTN.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.CashClear);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motorHP);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "FiveM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox motorHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button CashClear;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox priceBTN;
    }
}

