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
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.motorHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.clearBtn = new System.Windows.Forms.Button();
            this.vehiclesCb = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(11, 92);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(79, 43);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(119, 92);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(79, 43);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
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
            this.motorHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(104, 28);
            this.progressBar.TabIndex = 5;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(45, 385);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(79, 43);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // vehiclesCb
            // 
            this.vehiclesCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehiclesCb.FormattingEnabled = true;
            this.vehiclesCb.Items.AddRange(new object[] {
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
            this.vehiclesCb.Location = new System.Drawing.Point(339, 76);
            this.vehiclesCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehiclesCb.Name = "vehiclesCb";
            this.vehiclesCb.Size = new System.Drawing.Size(148, 24);
            this.vehiclesCb.Sorted = true;
            this.vehiclesCb.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(607, 75);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(64, 25);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(511, 76);
            this.priceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceBox.MinimumSize = new System.Drawing.Size(45, 24);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(45, 22);
            this.priceBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ár";
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(691, 76);
            this.summaryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(95, 25);
            this.summaryBtn.TabIndex = 11;
            this.summaryBtn.Text = "Summary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.vehiclesCb);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motorHP);
            this.Controls.Add(this.result);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sōkaiya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox motorHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ComboBox vehiclesCb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button summaryBtn;
    }
}

