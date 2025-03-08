using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HastaneProjesi;
namespace Ders1
{
    public partial class FrmBrans : Form
    {

        SQLbaglantısı bgl = new SQLbaglantısı();
        public FrmBrans()
        {
            InitializeComponent();
        }
        private void FrmBrans_Load_1(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branslar where Bransid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where Bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tıklayınca sütunlara göre textboxlara yazdırma
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();

        }
    }
}
