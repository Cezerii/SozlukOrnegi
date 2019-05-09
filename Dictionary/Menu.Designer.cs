namespace Dictionary
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngilziceAnlami = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurkceAnlami = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IKelimeTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KelimeTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cumle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eklebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.aratxt = new System.Windows.Forms.TextBox();
            this.arabtn = new System.Windows.Forms.Button();
            this.verigetirbtn = new System.Windows.Forms.Button();
            this.ogren = new System.Windows.Forms.Button();
            this.inglizcetxt = new System.Windows.Forms.TextBox();
            this.idtut = new System.Windows.Forms.TextBox();
            this.geri = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranacak Kelime";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IngilziceAnlami,
            this.TurkceAnlami,
            this.IKelimeTuru,
            this.KelimeTuru,
            this.Cumle});
            this.dataGridView1.Location = new System.Drawing.Point(101, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(505, 240);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // IngilziceAnlami
            // 
            this.IngilziceAnlami.DataPropertyName = "IngilziceAnlami";
            this.IngilziceAnlami.HeaderText = "İngilizce karşılığı";
            this.IngilziceAnlami.Name = "IngilziceAnlami";
            // 
            // TurkceAnlami
            // 
            this.TurkceAnlami.DataPropertyName = "TurkceAnlami";
            this.TurkceAnlami.HeaderText = "Türkçe ";
            this.TurkceAnlami.Name = "TurkceAnlami";
            // 
            // IKelimeTuru
            // 
            this.IKelimeTuru.DataPropertyName = "IKelimeTuru";
            this.IKelimeTuru.HeaderText = "word type";
            this.IKelimeTuru.Name = "IKelimeTuru";
            // 
            // KelimeTuru
            // 
            this.KelimeTuru.DataPropertyName = "KelimeTuru";
            this.KelimeTuru.HeaderText = "Kelime Türü";
            this.KelimeTuru.Name = "KelimeTuru";
            // 
            // Cumle
            // 
            this.Cumle.DataPropertyName = "Cumle";
            this.Cumle.HeaderText = "Kelime ile ilgili cümle";
            this.Cumle.Name = "Cumle";
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(12, 324);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(102, 40);
            this.eklebtn.TabIndex = 5;
            this.eklebtn.Text = "KELİME EKLEME";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(155, 324);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(102, 40);
            this.silbtn.TabIndex = 6;
            this.silbtn.Text = "KELİMEYİ SİL";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(576, 324);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(102, 40);
            this.guncellebtn.TabIndex = 7;
            this.guncellebtn.Text = "KELİMEYİ GÜNCELLE";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.Guncellebtn_Click);
            // 
            // aratxt
            // 
            this.aratxt.Location = new System.Drawing.Point(269, 16);
            this.aratxt.Name = "aratxt";
            this.aratxt.Size = new System.Drawing.Size(151, 20);
            this.aratxt.TabIndex = 8;
            // 
            // arabtn
            // 
            this.arabtn.BackgroundImage = global::Dictionary.Properties.Resources.ara;
            this.arabtn.Location = new System.Drawing.Point(453, 17);
            this.arabtn.Name = "arabtn";
            this.arabtn.Size = new System.Drawing.Size(76, 24);
            this.arabtn.TabIndex = 9;
            this.arabtn.Text = "ARA";
            this.arabtn.UseVisualStyleBackColor = true;
            this.arabtn.Click += new System.EventHandler(this.Arabtn_Click);
            // 
            // verigetirbtn
            // 
            this.verigetirbtn.Location = new System.Drawing.Point(298, 323);
            this.verigetirbtn.Name = "verigetirbtn";
            this.verigetirbtn.Size = new System.Drawing.Size(102, 40);
            this.verigetirbtn.TabIndex = 25;
            this.verigetirbtn.Text = "TABLOYU GETİR";
            this.verigetirbtn.UseVisualStyleBackColor = true;
            this.verigetirbtn.Click += new System.EventHandler(this.Verigetirbtn_Click);
            // 
            // ogren
            // 
            this.ogren.Location = new System.Drawing.Point(437, 324);
            this.ogren.Name = "ogren";
            this.ogren.Size = new System.Drawing.Size(102, 40);
            this.ogren.TabIndex = 28;
            this.ogren.Text = "KELİME ÖĞRENME";
            this.ogren.UseVisualStyleBackColor = true;
            this.ogren.Click += new System.EventHandler(this.Ogren_Click);
            // 
            // inglizcetxt
            // 
            this.inglizcetxt.Location = new System.Drawing.Point(51, 419);
            this.inglizcetxt.Name = "inglizcetxt";
            this.inglizcetxt.Size = new System.Drawing.Size(11, 20);
            this.inglizcetxt.TabIndex = 30;
            this.inglizcetxt.Visible = false;
            // 
            // idtut
            // 
            this.idtut.Location = new System.Drawing.Point(12, 419);
            this.idtut.Name = "idtut";
            this.idtut.Size = new System.Drawing.Size(18, 20);
            this.idtut.TabIndex = 10;
            this.idtut.Visible = false;
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Transparent;
            this.geri.BackgroundImage = global::Dictionary.Properties.Resources.icons8_go_back_30;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.ForeColor = System.Drawing.Color.OldLace;
            this.geri.Location = new System.Drawing.Point(603, 4);
            this.geri.Name = "geri";
            this.geri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.geri.Size = new System.Drawing.Size(29, 32);
            this.geri.TabIndex = 31;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.BackgroundImage = global::Dictionary.Properties.Resources._12;
            this.cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.ForeColor = System.Drawing.Color.OldLace;
            this.cikis.Location = new System.Drawing.Point(649, 4);
            this.cikis.Name = "cikis";
            this.cikis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cikis.Size = new System.Drawing.Size(29, 32);
            this.cikis.TabIndex = 33;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // timer1
            // 
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Dictionary.Properties.Resources.kitap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 375);
            this.ControlBox = false;
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.inglizcetxt);
            this.Controls.Add(this.ogren);
            this.Controls.Add(this.verigetirbtn);
            this.Controls.Add(this.idtut);
            this.Controls.Add(this.arabtn);
            this.Controls.Add(this.aratxt);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.TextBox aratxt;
        private System.Windows.Forms.Button arabtn;
        private System.Windows.Forms.Button verigetirbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngilziceAnlami;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurkceAnlami;
        private System.Windows.Forms.DataGridViewTextBoxColumn IKelimeTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn KelimeTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cumle;
        private System.Windows.Forms.Button ogren;
        private System.Windows.Forms.TextBox inglizcetxt;
        private System.Windows.Forms.TextBox idtut;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Timer timer1;
    }
}