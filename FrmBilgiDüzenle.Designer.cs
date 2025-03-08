namespace HastaneProjesi
{
    partial class FrmBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDüzenle));
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msktelno = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnbilgidüzenle = new System.Windows.Forms.Button();
            this.msktcno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(222, 265);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(242, 41);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 35);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cinsiyet :";
            // 
            // msktelno
            // 
            this.msktelno.Location = new System.Drawing.Point(222, 173);
            this.msktelno.Mask = "(999) 000-0000";
            this.msktelno.Name = "msktelno";
            this.msktelno.Size = new System.Drawing.Size(242, 40);
            this.msktelno.TabIndex = 4;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(222, 217);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(242, 40);
            this.txtsifre.TabIndex = 5;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(222, 80);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(242, 40);
            this.txtsoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 35);
            this.label5.TabIndex = 28;
            this.label5.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 35);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tel No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "T.C Kimlik No :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(222, 35);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(242, 40);
            this.txtad.TabIndex = 1;
            // 
            // btnbilgidüzenle
            // 
            this.btnbilgidüzenle.Location = new System.Drawing.Point(222, 312);
            this.btnbilgidüzenle.Name = "btnbilgidüzenle";
            this.btnbilgidüzenle.Size = new System.Drawing.Size(242, 48);
            this.btnbilgidüzenle.TabIndex = 7;
            this.btnbilgidüzenle.Text = "Bilgileri Düzenle";
            this.btnbilgidüzenle.UseVisualStyleBackColor = true;
            this.btnbilgidüzenle.Click += new System.EventHandler(this.btnbilgidüzenle_Click);
            // 
            // msktcno
            // 
            this.msktcno.Location = new System.Drawing.Point(222, 129);
            this.msktcno.Mask = "00000000000";
            this.msktcno.Name = "msktcno";
            this.msktcno.Size = new System.Drawing.Size(242, 40);
            this.msktcno.TabIndex = 3;
            this.msktcno.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.TabIndex = 22;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 35);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ad :";
            // 
            // FrmBilgiDüzenle
            // 
            this.AcceptButton = this.btnbilgidüzenle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 406);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msktelno);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.btnbilgidüzenle);
            this.Controls.Add(this.msktcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimizeBox = false;
            this.Name = "FrmBilgiDüzenle";
            this.Text = "Bilgi Güncelleme Paneli";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktelno;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnbilgidüzenle;
        private System.Windows.Forms.MaskedTextBox msktcno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}