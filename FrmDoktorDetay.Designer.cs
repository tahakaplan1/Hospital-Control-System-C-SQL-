namespace HastaneProjesi
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltcno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchsikayett = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnbilgigüncelle = new System.Windows.Forms.Button();
            this.btnınternet = new System.Windows.Forms.Button();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltcno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(126, 91);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(93, 28);
            this.lbladsoyad.TabIndex = 4;
            this.lbladsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad :";
            // 
            // lbltcno
            // 
            this.lbltcno.AutoSize = true;
            this.lbltcno.Location = new System.Drawing.Point(126, 51);
            this.lbltcno.Name = "lbltcno";
            this.lbltcno.Size = new System.Drawing.Size(144, 28);
            this.lbltcno.TabIndex = 2;
            this.lbltcno.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchsikayett);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchsikayett
            // 
            this.rchsikayett.Location = new System.Drawing.Point(12, 85);
            this.rchsikayett.Name = "rchsikayett";
            this.rchsikayett.Size = new System.Drawing.Size(349, 264);
            this.rchsikayett.TabIndex = 6;
            this.rchsikayett.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasta Şikayet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(410, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 710);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 675);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnbilgigüncelle);
            this.groupBox4.Controls.Add(this.btnınternet);
            this.groupBox4.Controls.Add(this.btnduyurular);
            this.groupBox4.Controls.Add(this.btncıkıs);
            this.groupBox4.Location = new System.Drawing.Point(9, 538);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 184);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // btnbilgigüncelle
            // 
            this.btnbilgigüncelle.Location = new System.Drawing.Point(12, 114);
            this.btnbilgigüncelle.Name = "btnbilgigüncelle";
            this.btnbilgigüncelle.Size = new System.Drawing.Size(164, 53);
            this.btnbilgigüncelle.TabIndex = 0;
            this.btnbilgigüncelle.Text = "Bilgi Düzenle";
            this.btnbilgigüncelle.UseVisualStyleBackColor = true;
            this.btnbilgigüncelle.Click += new System.EventHandler(this.btnbilgigüncelle_Click);
            // 
            // btnınternet
            // 
            this.btnınternet.Location = new System.Drawing.Point(12, 44);
            this.btnınternet.Name = "btnınternet";
            this.btnınternet.Size = new System.Drawing.Size(164, 53);
            this.btnınternet.TabIndex = 3;
            this.btnınternet.Text = "İnternet";
            this.btnınternet.UseVisualStyleBackColor = true;
            // 
            // btnduyurular
            // 
            this.btnduyurular.Location = new System.Drawing.Point(197, 44);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(164, 53);
            this.btnduyurular.TabIndex = 1;
            this.btnduyurular.Text = "Duyurular";
            this.btnduyurular.UseVisualStyleBackColor = true;
            this.btnduyurular.Click += new System.EventHandler(this.btnduyurular_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.Location = new System.Drawing.Point(197, 114);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(164, 53);
            this.btncıkıs.TabIndex = 2;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1253, 734);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltcno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchsikayett;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnınternet;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btnduyurular;
        private System.Windows.Forms.Button btnbilgigüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}