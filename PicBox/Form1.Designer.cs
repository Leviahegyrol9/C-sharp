namespace PicBox
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
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.cB2 = new System.Windows.Forms.ComboBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.cB3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(150, 244);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(148, 134);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 0;
            this.picBox2.TabStop = false;
            // 
            // cB2
            // 
            this.cB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB2.FormattingEnabled = true;
            this.cB2.Location = new System.Drawing.Point(161, 211);
            this.cB2.Name = "cB2";
            this.cB2.Size = new System.Drawing.Size(128, 21);
            this.cB2.TabIndex = 1;
            this.cB2.SelectedIndexChanged += new System.EventHandler(this.cB2_SelectedIndexChanged);
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(487, 244);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(148, 134);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox3.TabIndex = 2;
            this.picBox3.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(322, 85);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(148, 134);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 3;
            this.picBox1.TabStop = false;
            // 
            // cB1
            // 
            this.cB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB1.FormattingEnabled = true;
            this.cB1.Location = new System.Drawing.Point(333, 47);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(128, 21);
            this.cB1.TabIndex = 4;
            this.cB1.SelectedIndexChanged += new System.EventHandler(this.cB1_SelectedIndexChanged);
            // 
            // cB3
            // 
            this.cB3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB3.FormattingEnabled = true;
            this.cB3.Location = new System.Drawing.Point(498, 211);
            this.cB3.Name = "cB3";
            this.cB3.Size = new System.Drawing.Size(128, 21);
            this.cB3.TabIndex = 5;
            this.cB3.SelectedIndexChanged += new System.EventHandler(this.cB3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cB3);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.cB2);
            this.Controls.Add(this.picBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.ComboBox cB2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.ComboBox cB3;
    }
}

