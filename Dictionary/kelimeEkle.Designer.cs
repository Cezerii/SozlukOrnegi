namespace Dictionary
{
    partial class kelimeEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ingilizceturucbx = new System.Windows.Forms.ComboBox();
            this.Turkceturucbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cumletxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Ingilizceturucbx);
            this.groupBox1.Controls.Add(this.Turkceturucbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cumletxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KELİME EKLEME";
            // 
            // Ingilizceturucbx
            // 
            this.Ingilizceturucbx.FormattingEnabled = true;
            this.Ingilizceturucbx.Items.AddRange(new object[] {
            "noun(isim",
            "verb(fiil)",
            "adverb(zarf)",
            "adjective(sıfat)"});
            this.Ingilizceturucbx.Location = new System.Drawing.Point(253, 204);
            this.Ingilizceturucbx.Name = "Ingilizceturucbx";
            this.Ingilizceturucbx.Size = new System.Drawing.Size(146, 21);
            this.Ingilizceturucbx.TabIndex = 33;
            // 
            // Turkceturucbx
            // 
            this.Turkceturucbx.FormattingEnabled = true;
            this.Turkceturucbx.Items.AddRange(new object[] {
            "isim",
            "sıfat",
            "zarf",
            "fiil"});
            this.Turkceturucbx.Location = new System.Drawing.Point(253, 152);
            this.Turkceturucbx.Name = "Turkceturucbx";
            this.Turkceturucbx.Size = new System.Drawing.Size(146, 21);
            this.Turkceturucbx.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Kelimenin İngilizce Karşılığındaki Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kelimenin Türkçe Karşılığındaki Türü";
            // 
            // cumletxt
            // 
            this.cumletxt.Location = new System.Drawing.Point(253, 257);
            this.cumletxt.Name = "cumletxt";
            this.cumletxt.Size = new System.Drawing.Size(146, 20);
            this.cumletxt.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kelime İle İlgili Cümle";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelimenin İngilizce Karşılığı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelimenin Türkçe Karşılığı";
            // 
            // kelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dictionary.Properties.Resources.beyin;
            this.ClientSize = new System.Drawing.Size(498, 367);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kelimeEkle";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "kelimeEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cumletxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Ingilizceturucbx;
        private System.Windows.Forms.ComboBox Turkceturucbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}