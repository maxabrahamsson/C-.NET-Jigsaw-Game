namespace PuzzleNS
{
  partial class PuzzleForm
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
        this.PnlPuzzle = new System.Windows.Forms.Panel();
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.listBox1 = new System.Windows.Forms.ListBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.button1 = new System.Windows.Forms.Button();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.radioButton5 = new System.Windows.Forms.RadioButton();
        this.radioButton1 = new System.Windows.Forms.RadioButton();
        this.radioButton4 = new System.Windows.Forms.RadioButton();
        this.radioButton2 = new System.Windows.Forms.RadioButton();
        this.radioButton3 = new System.Windows.Forms.RadioButton();
        this.button2 = new System.Windows.Forms.Button();
        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        this.label1 = new System.Windows.Forms.Label();
        this.button3 = new System.Windows.Forms.Button();
        this.PnlPuzzle.SuspendLayout();
        this.groupBox4.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.SuspendLayout();
        // 
        // PnlPuzzle
        // 
        this.PnlPuzzle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.PnlPuzzle.Controls.Add(this.groupBox4);
        this.PnlPuzzle.Controls.Add(this.groupBox1);
        this.PnlPuzzle.Location = new System.Drawing.Point(12, 12);
        this.PnlPuzzle.Name = "PnlPuzzle";
        this.PnlPuzzle.Size = new System.Drawing.Size(660, 346);
        this.PnlPuzzle.TabIndex = 0;
        // 
        // groupBox4
        // 
        this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox4.Controls.Add(this.listBox1);
        this.groupBox4.Location = new System.Drawing.Point(441, 3);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new System.Drawing.Size(216, 340);
        this.groupBox4.TabIndex = 4;
        this.groupBox4.TabStop = false;
        this.groupBox4.Text = "Skorlar";
        // 
        // listBox1
        // 
        this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.listBox1.FormattingEnabled = true;
        this.listBox1.Location = new System.Drawing.Point(3, 16);
        this.listBox1.Name = "listBox1";
        this.listBox1.Size = new System.Drawing.Size(210, 321);
        this.listBox1.TabIndex = 0;
        // 
        // groupBox1
        // 
        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)));
        this.groupBox1.Controls.Add(this.groupBox3);
        this.groupBox1.Controls.Add(this.groupBox2);
        this.groupBox1.Controls.Add(this.button2);
        this.groupBox1.Location = new System.Drawing.Point(0, 3);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(435, 319);
        this.groupBox1.TabIndex = 3;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Yeni Oyun";
        // 
        // groupBox3
        // 
        this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox3.Controls.Add(this.button1);
        this.groupBox3.Location = new System.Drawing.Point(6, 19);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(318, 213);
        this.groupBox3.TabIndex = 8;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Yap-Boz Resmi";
        // 
        // button1
        // 
        this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.button1.Dock = System.Windows.Forms.DockStyle.Top;
        this.button1.Location = new System.Drawing.Point(3, 16);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(312, 185);
        this.button1.TabIndex = 0;
        this.button1.Text = "Resim Seç";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // groupBox2
        // 
        this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox2.Controls.Add(this.radioButton5);
        this.groupBox2.Controls.Add(this.radioButton1);
        this.groupBox2.Controls.Add(this.radioButton4);
        this.groupBox2.Controls.Add(this.radioButton2);
        this.groupBox2.Controls.Add(this.radioButton3);
        this.groupBox2.Location = new System.Drawing.Point(330, 19);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(99, 210);
        this.groupBox2.TabIndex = 7;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Zorluk Derecesi";
        // 
        // radioButton5
        // 
        this.radioButton5.AutoSize = true;
        this.radioButton5.Location = new System.Drawing.Point(6, 26);
        this.radioButton5.Name = "radioButton5";
        this.radioButton5.Size = new System.Drawing.Size(48, 17);
        this.radioButton5.TabIndex = 2;
        this.radioButton5.TabStop = true;
        this.radioButton5.Text = "2 x 2";
        this.radioButton5.UseVisualStyleBackColor = true;
        // 
        // radioButton1
        // 
        this.radioButton1.AutoSize = true;
        this.radioButton1.Location = new System.Drawing.Point(6, 49);
        this.radioButton1.Name = "radioButton1";
        this.radioButton1.Size = new System.Drawing.Size(48, 17);
        this.radioButton1.TabIndex = 3;
        this.radioButton1.Text = "3 x 3";
        this.radioButton1.UseVisualStyleBackColor = true;
        // 
        // radioButton4
        // 
        this.radioButton4.AutoSize = true;
        this.radioButton4.Location = new System.Drawing.Point(6, 118);
        this.radioButton4.Name = "radioButton4";
        this.radioButton4.Size = new System.Drawing.Size(48, 17);
        this.radioButton4.TabIndex = 6;
        this.radioButton4.Text = "6 x 6";
        this.radioButton4.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        this.radioButton2.AutoSize = true;
        this.radioButton2.Checked = true;
        this.radioButton2.Location = new System.Drawing.Point(6, 72);
        this.radioButton2.Name = "radioButton2";
        this.radioButton2.Size = new System.Drawing.Size(48, 17);
        this.radioButton2.TabIndex = 4;
        this.radioButton2.TabStop = true;
        this.radioButton2.Text = "4 x 4";
        this.radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton3
        // 
        this.radioButton3.AutoSize = true;
        this.radioButton3.Location = new System.Drawing.Point(6, 95);
        this.radioButton3.Name = "radioButton3";
        this.radioButton3.Size = new System.Drawing.Size(48, 17);
        this.radioButton3.TabIndex = 5;
        this.radioButton3.Text = "5 x 5";
        this.radioButton3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.button2.Location = new System.Drawing.Point(3, 238);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(429, 78);
        this.button2.TabIndex = 2;
        this.button2.Text = "Baþlat";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // openFileDialog1
        // 
        this.openFileDialog1.FileName = "openFileDialog1";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(637, 358);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(0, 13);
        this.label1.TabIndex = 1;
        // 
        // button3
        // 
        this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.button3.Location = new System.Drawing.Point(597, 364);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(75, 23);
        this.button3.TabIndex = 2;
        this.button3.Text = "Hakkýnda";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // jigsaw
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(684, 391);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.PnlPuzzle);
        this.MinimumSize = new System.Drawing.Size(700, 415);
        this.Name = "jigsaw";
        this.Text = "Yap-Boz 2.0";
        this.Load += new System.EventHandler(this.jigsaw_Load);
        this.PnlPuzzle.ResumeLayout(false);
        this.groupBox4.ResumeLayout(false);
        this.groupBox1.ResumeLayout(false);
        this.groupBox3.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlPuzzle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

