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
            this.vehicles = new System.Windows.Forms.ComboBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.summaryBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 75);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(59, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.start_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(89, 75);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(59, 35);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Stop";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.end_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(9, 7);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.MinimumSize = new System.Drawing.Size(75, 20);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 20);
            this.result.TabIndex = 2;
            // 
            // motorHP
            // 
            this.motorHP.Location = new System.Drawing.Point(179, 90);
            this.motorHP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.motorHP.Name = "motorHP";
            this.motorHP.Size = new System.Drawing.Size(35, 20);
            this.motorHP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Motor %";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(45, 129);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(78, 23);
            this.progressBar.TabIndex = 5;
            // 
            // CashClear
            // 
            this.CashClear.Location = new System.Drawing.Point(34, 313);
            this.CashClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CashClear.Name = "CashClear";
            this.CashClear.Size = new System.Drawing.Size(59, 35);
            this.CashClear.TabIndex = 6;
            this.CashClear.Text = "Clear";
            this.CashClear.UseVisualStyleBackColor = true;
            this.CashClear.Click += new System.EventHandler(this.CashClear_Click);
            // 
            // vehicles
            // 
            this.vehicles.FormattingEnabled = true;
            this.vehicles.Items.AddRange(new object[] {
            "Audi RS5 2011 BJS 32",
            "BMW S-1000 RR PVZ 53",
            "BMW X7 HCD 72",
            "Brabus ML63 GOQ 84",
            "Dodge RAM TRX Reaper 2022 OFFROAD LXW 10",
            "Ford Raptor Scorpion 2017 NGR 84",
            "Kawasaki Ninja ZX6R GIY 62",
            "KTM Cross MDK 63",
            "KTM Cross RZR 64",
            "Limousine YJH 53",
            "Mercedes C63 AMG 2012 LIH 21"});
            this.vehicles.Location = new System.Drawing.Point(254, 62);
            this.vehicles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehicles.Name = "vehicles";
            this.vehicles.Size = new System.Drawing.Size(112, 21);
            this.vehicles.Sorted = true;
            this.vehicles.TabIndex = 7;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(455, 61);
            this.addBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(48, 20);
            this.addBTN.TabIndex = 8;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(383, 62);
            this.priceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceBox.MinimumSize = new System.Drawing.Size(35, 24);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(35, 20);
            this.priceBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ár";
            // 
            // summaryBTN
            // 
            this.summaryBTN.Location = new System.Drawing.Point(518, 62);
            this.summaryBTN.Margin = new System.Windows.Forms.Padding(2);
            this.summaryBTN.Name = "summaryBTN";
            this.summaryBTN.Size = new System.Drawing.Size(71, 20);
            this.summaryBTN.TabIndex = 11;
            this.summaryBTN.Text = "Summary";
            this.summaryBTN.UseVisualStyleBackColor = true;
            this.summaryBTN.Click += new System.EventHandler(this.summaryBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.summaryBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.vehicles);
            this.Controls.Add(this.CashClear);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motorHP);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ComboBox vehicles;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button summaryBTN;
    }
}

