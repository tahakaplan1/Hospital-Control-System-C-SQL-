namespace HastaneProjesi
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblADSOYAD = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNduyuruoluştur = new System.Windows.Forms.Button();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.CmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.CmbBranş = new System.Windows.Forms.ComboBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuListe = new System.Windows.Forms.Button();
            this.BtnBranşPAnel = new System.Windows.Forms.Button();
            this.BtnDoktorPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblADSOYAD);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblADSOYAD
            // 
            this.LblADSOYAD.AutoSize = true;
            this.LblADSOYAD.Location = new System.Drawing.Point(130, 79);
            this.LblADSOYAD.Name = "LblADSOYAD";
            this.LblADSOYAD.Size = new System.Drawing.Size(85, 28);
            this.LblADSOYAD.TabIndex = 3;
            this.LblADSOYAD.Text = "null null";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(130, 51);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(144, 28);
            this.LblTC.TabIndex = 2;
            this.LblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNduyuruoluştur);
            this.groupBox2.Controls.Add(this.RchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 367);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // BTNduyuruoluştur
            // 
            this.BTNduyuruoluştur.Location = new System.Drawing.Point(109, 259);
            this.BTNduyuruoluştur.Name = "BTNduyuruoluştur";
            this.BTNduyuruoluştur.Size = new System.Drawing.Size(105, 37);
            this.BTNduyuruoluştur.TabIndex = 1;
            this.BTNduyuruoluştur.Text = "Oluştur";
            this.BTNduyuruoluştur.UseVisualStyleBackColor = true;
            this.BTNduyuruoluştur.Click += new System.EventHandler(this.BTNduyuruoluştur_Click);
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(15, 35);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(286, 218);
            this.RchDuyuru.TabIndex = 0;
            this.RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKaydet);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.MskTC);
            this.groupBox3.Controls.Add(this.CmbDoktorlar);
            this.groupBox3.Controls.Add(this.CmbBranş);
            this.groupBox3.Controls.Add(this.MskSaat);
            this.groupBox3.Controls.Add(this.MskTarih);
            this.groupBox3.Controls.Add(this.Txtid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(350, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 528);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(61, 353);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(289, 61);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 315);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 32);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Durum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(113, 273);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(200, 36);
            this.MskTC.TabIndex = 11;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // CmbDoktorlar
            // 
            this.CmbDoktorlar.FormattingEnabled = true;
            this.CmbDoktorlar.Location = new System.Drawing.Point(114, 228);
            this.CmbDoktorlar.Name = "CmbDoktorlar";
            this.CmbDoktorlar.Size = new System.Drawing.Size(200, 36);
            this.CmbDoktorlar.TabIndex = 10;
            // 
            // CmbBranş
            // 
            this.CmbBranş.FormattingEnabled = true;
            this.CmbBranş.Location = new System.Drawing.Point(114, 183);
            this.CmbBranş.Name = "CmbBranş";
            this.CmbBranş.Size = new System.Drawing.Size(200, 36);
            this.CmbBranş.TabIndex = 9;
            this.CmbBranş.SelectedIndexChanged += new System.EventHandler(this.CmbBranş_SelectedIndexChanged);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(113, 138);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(200, 36);
            this.MskSaat.TabIndex = 8;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(113, 93);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(200, 36);
            this.MskTarih.TabIndex = 7;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(113, 48);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(200, 36);
            this.Txtid.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "T.C No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Doktor :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Branş :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tarih :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Saat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "İD :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(753, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 357);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(490, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(756, 375);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(496, 335);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(490, 300);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BtnRandevuListe);
            this.groupBox6.Controls.Add(this.BtnBranşPAnel);
            this.groupBox6.Controls.Add(this.BtnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(6, 546);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(741, 160);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // BtnRandevuListe
            // 
            this.BtnRandevuListe.Location = new System.Drawing.Point(369, 46);
            this.BtnRandevuListe.Name = "BtnRandevuListe";
            this.BtnRandevuListe.Size = new System.Drawing.Size(159, 92);
            this.BtnRandevuListe.TabIndex = 16;
            this.BtnRandevuListe.Text = "Randevu Liste";
            this.BtnRandevuListe.UseVisualStyleBackColor = true;
            this.BtnRandevuListe.Click += new System.EventHandler(this.BtnRandevuListe_Click);
            // 
            // BtnBranşPAnel
            // 
            this.BtnBranşPAnel.Location = new System.Drawing.Point(37, 46);
            this.BtnBranşPAnel.Name = "BtnBranşPAnel";
            this.BtnBranşPAnel.Size = new System.Drawing.Size(159, 92);
            this.BtnBranşPAnel.TabIndex = 15;
            this.BtnBranşPAnel.Text = "Branş Paneli";
            this.BtnBranşPAnel.UseVisualStyleBackColor = true;
            this.BtnBranşPAnel.Click += new System.EventHandler(this.BtnBranşPAnel_Click);
            // 
            // BtnDoktorPanel
            // 
            this.BtnDoktorPanel.Location = new System.Drawing.Point(203, 46);
            this.BtnDoktorPanel.Name = "BtnDoktorPanel";
            this.BtnDoktorPanel.Size = new System.Drawing.Size(159, 92);
            this.BtnDoktorPanel.TabIndex = 14;
            this.BtnDoktorPanel.Text = "Doktor Paneli";
            this.BtnDoktorPanel.UseVisualStyleBackColor = true;
            this.BtnDoktorPanel.Click += new System.EventHandler(this.BtnDoktorPanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 92);
            this.button1.TabIndex = 17;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1296, 718);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay Paneli";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblADSOYAD;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNduyuruoluştur;
        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.ComboBox CmbDoktorlar;
        private System.Windows.Forms.ComboBox CmbBranş;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnRandevuListe;
        private System.Windows.Forms.Button BtnBranşPAnel;
        private System.Windows.Forms.Button BtnDoktorPanel;
        private System.Windows.Forms.Button button1;
    }
}