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

namespace Personel_Kayit
{
    public partial class FrmAnaForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source=MSI;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            TxtPersonelId.Text = string.Empty;
            TxtPersonelAd.Text = string.Empty;
            TxtPersonelSoyad.Text = string.Empty;
            CmbPersonelSehir.Text = string.Empty;
            MskPersonelMaas.Text = string.Empty;
            TxtPersonelMeslek.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtPersonelAd.Focus();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Personel (PerAd, PerSoyad, PerSehir, PerMaas, PerDurum, PerMeslek) values (@p1, @p2, @p3, @p4, @p5, @p6)", SqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtPersonelSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", CmbPersonelSehir.Text);
            sqlCommand.Parameters.AddWithValue("@p4", MskPersonelMaas.Text);
            sqlCommand.Parameters.AddWithValue("@p5", label8.Text);
            sqlCommand.Parameters.AddWithValue("@p6", TxtPersonelMeslek.Text);
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "true";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "false";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            TxtPersonelId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            TxtPersonelAd.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtPersonelSoyad.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            CmbPersonelSehir.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            MskPersonelMaas.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            TxtPersonelMeslek.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete From Tbl_Personel Where PerId = @p1", SqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", TxtPersonelId.Text);
            sqlCommand.ExecuteNonQuery();                
            SqlConnection.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Tbl_Personel Set PerAd = @p1, PerSoyad = @p2, PerSehir = @p3, PerMaas = @p4, PerDurum = @p5, PerMeslek = @p6 where PerId = @p7", SqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtPersonelSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", CmbPersonelSehir.Text);
            sqlCommand.Parameters.AddWithValue("@p4", MskPersonelMaas.Text);
            sqlCommand.Parameters.AddWithValue("@p5", label8.Text);
            sqlCommand.Parameters.AddWithValue("@p6", TxtPersonelMeslek.Text);
            sqlCommand.Parameters.AddWithValue("@p7", TxtPersonelId.Text);
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("Personel Bilgi Güncellendi");
        }

        private void Btnİstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frmIstatistik = new FrmIstatistik();
            frmIstatistik.Show();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();
        }
    }
}
