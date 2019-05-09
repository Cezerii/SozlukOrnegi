namespace Dictionary
{
    partial class kelimeGüncellemeFrm
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
            this.cumletxt = new System.Windows.Forms.TextBox();
            this.Ingilizceturucbx = new System.Windows.Forms.ComboBox();
            this.Turkceturucbx = new System.Windows.Forms.ComboBox();
            this.temizlebtn = new System.Windows.Forms.Button();
            this.inglizcetxt = new System.Windows.Forms.TextBox();
            this.turkcetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cumletxt
            // 
            this.cumletxt.Location = new System.Drawing.Point(242, 239);
            this.cumletxt.Name = "cumletxt";
            this.cumletxt.Size = new System.Drawing.Size(143, 20);
            this.cumletxt.TabIndex = 38;
            // 
            // Ingilizceturucbx
            // 
            this.Ingilizceturucbx.FormattingEnabled = true;
            this.Ingilizceturucbx.Items.AddRange(new object[] {
            "noun(isim",
            "verb(fiil)",
            "adverb(zarf)",
            "adjective(sıfat)"});
            this.Ingilizceturucbx.Location = new System.Drawing.Point(242, 187);
            this.Ingilizceturucbx.Name = "Ingilizceturucbx";
            this.Ingilizceturucbx.Size = new System.Drawing.Size(146, 21);
            this.Ingilizceturucbx.TabIndex = 37;
            // 
            // Turkceturucbx
            // 
            this.Turkceturucbx.FormattingEnabled = true;
            this.Turkceturucbx.Items.AddRange(new object[] {
            "isim",
            "sıfat",
            "zarf",
            "fiil"});
            this.Turkceturucbx.Location = new System.Drawing.Point(242, 129);
            this.Turkceturucbx.Name = "Turkceturucbx";
            this.Turkceturucbx.Size = new System.Drawing.Size(146, 21);
            this.Turkceturucbx.TabIndex = 36;
            // 
            // temizlebtn
            // 
            this.temizlebtn.Location = new System.Drawing.Point(283, 293);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(102, 40);
            this.temizlebtn.TabIndex = 35;
            this.temizlebtn.Text = "TEMİZLE";
            this.temizlebtn.UseVisualStyleBackColor = true;
            this.temizlebtn.Click += new System.EventHandler(this.Temizlebtn_Click);
            // 
            // inglizcetxt
            // 
            this.inglizcetxt.Location = new System.Drawing.Point(245, 67);
            this.inglizcetxt.Name = "inglizcetxt";
            this.inglizcetxt.Size = new System.Drawing.Size(143, 20);
            this.inglizcetxt.TabIndex = 34;
            // 
            // turkcetxt
            // 
            this.turkcetxt.Location = new System.Drawing.Point(245, 9);
            this.turkcetxt.Name = "turkcetxt";
            this.turkcetxt.Size = new System.Drawing.Size(143, 20);
            this.turkcetxt.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kelimenin İngilizce Karşılığındaki Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Kelimenin Türkçe Karşılığındaki Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kelimenin İngilizce Karşılığı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kelimenin Türkçe Karşılığı";
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(92, 293);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(102, 40);
            this.guncellebtn.TabIndex = 28;
            this.guncellebtn.Text = "KELİMEYİ GÜNCELLE";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.Guncellebtn_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.BackgroundImage = global::Dictionary.Properties.Resources._12;
            this.cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.ForeColor = System.Drawing.Color.OldLace;
            this.cikis.Location = new System.Drawing.Point(541, 12);
            this.cikis.Name = "cikis";
            this.cikis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cikis.Size = new System.Drawing.Size(29, 32);
            this.cikis.TabIndex = 40;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Transparent;
            this.geri.BackgroundImage = global::Dictionary.Properties.Resources.icons8_go_back_30;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.ForeColor = System.Drawing.Color.OldLace;
            this.geri.Location = new System.Drawing.Point(495, 12);
            this.geri.Name = "geri";
            this.geri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.geri.Size = new System.Drawing.Size(29, 32);
            this.geri.TabIndex = 39;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kelime ile ilgili cümle";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cumletxt);
            this.groupBox1.Controls.Add(this.Ingilizceturucbx);
            this.groupBox1.Controls.Add(this.Turkceturucbx);
            this.groupBox1.Controls.Add(this.temizlebtn);
            this.groupBox1.Controls.Add(this.inglizcetxt);
            this.groupBox1.Controls.Add(this.turkcetxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.guncellebtn);
            this.groupBox1.Location = new System.Drawing.Point(42, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 371);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 43;
            // 
            // kelimeGüncellemeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dictionary.Properties.Resources.kurt;
            this.ClientSize = new System.Drawing.Size(582, 424);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kelimeGüncellemeFrm";
            this.Text = "kelimeGüncellemeFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cumletxt;
        private System.Windows.Forms.ComboBox Ingilizceturucbx;
        private System.Windows.Forms.ComboBox Turkceturucbx;
        private System.Windows.Forms.Button temizlebtn;
        private System.Windows.Forms.TextBox inglizcetxt;
        private System.Windows.Forms.TextBox turkcetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}