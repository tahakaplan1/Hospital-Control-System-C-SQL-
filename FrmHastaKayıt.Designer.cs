namespace HastaneProjesi
{
    partial class FrmHastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayıt));
            this.Btnkayıtyap = new System.Windows.Forms.Button();
            this.msktcno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktelno = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btnkayıtyap
            // 
            this.Btnkayıtyap.Location = new System.Drawing.Point(166, 308);
            this.Btnkayıtyap.Name = "Btnkayıtyap";
            this.Btnkayıtyap.Size = new System.Drawing.Size(242, 50);
            this.Btnkayıtyap.TabIndex = 8;
            this.Btnkayıtyap.Text = "Kayıt Ol";
            this.Btnkayıtyap.UseVisualStyleBackColor = true;
            this.Btnkayıtyap.Click += new System.EventHandler(this.Btnkayıtyap_Click);
            // 
            // msktcno
            // 
            this.msktcno.Location = new System.Drawing.Point(166, 121);
            this.msktcno.Mask = "00000000000";
            this.msktcno.Name = "msktcno";
            this.msktcno.Size = new System.Drawing.Size(242, 36);
            this.msktcno.TabIndex = 3;
            this.msktcno.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(166, 27);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(242, 36);
            this.txtad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "T.C Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tel No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şifre :";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(166, 72);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(242, 36);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(166, 209);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(242, 36);
            this.txtsifre.TabIndex = 6;
            // 
            // msktelno
            // 
            this.msktelno.Location = new System.Drawing.Point(166, 165);
            this.msktelno.Mask = "(999) 000-0000";
            this.msktelno.Name = "msktelno";
            this.msktelno.Size = new System.Drawing.Size(242, 36);
            this.msktelno.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cinsiyet :";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(166, 257);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(242, 36);
            this.cmbcinsiyet.TabIndex = 7;
            // 
            // FrmHastaKayıt
            // 
            this.AcceptButton = this.Btnkayıtyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(476, 431);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msktelno);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.Btnkayıtyap);
            this.Controls.Add(this.msktcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayıt";
            this.Text = "Hasta Kayıt Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnkayıtyap;
        private System.Windows.Forms.MaskedTextBox msktcno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktelno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
    }
}