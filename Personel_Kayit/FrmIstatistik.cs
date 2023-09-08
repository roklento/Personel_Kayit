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
    public partial class FrmIstatistik : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source=MSI;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayısı
            SqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select count(*) from Tbl_Personel", SqlConnection);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LblToplamPer.Text = sqlDataReader[0].ToString();
            }
            SqlConnection.Close();

            // Evli Personel Sayısı
            SqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum = 1", SqlConnection);
            SqlDataReader sqlDataReader1 = sqlCommand2.ExecuteReader();
            while(sqlDataReader1.Read())
            {
                LblEvli.Text = sqlDataReader1[0].ToString();
            }
            SqlConnection.Close();

            // Bekar Personel Sayısı
            SqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum = 0", SqlConnection);
            SqlDataReader sqlDataReader2 = sqlCommand3.ExecuteReader();
            while(sqlDataReader2.Read())
            {
                LblBekar.Text = sqlDataReader2[0].ToString();
            }
            SqlConnection.Close();

            // Şehir Sayısı
            SqlConnection.Open();
            SqlCommand sqlCommand4 = new SqlCommand("select count(distinct(PerSehir)) From Tbl_Personel", SqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand4.ExecuteReader();
            while(sqlDataReader3.Read())
            {
                LblŞehirSayı.Text = sqlDataReader3[0].ToString();
            }
            SqlConnection.Close();

            // Toplam Maaş
            SqlConnection.Open();
            SqlCommand sqlCommand5 = new SqlCommand("select SUM(PerMaas) From Tbl_Personel", SqlConnection);
            SqlDataReader sqlDataReader4 = sqlCommand5.ExecuteReader();
            while(sqlDataReader4.Read())
            {
                LblToplamMaas.Text = sqlDataReader4[0].ToString();
            }
            SqlConnection.Close();

            // Ortalama Maaş
            SqlConnection.Open();
            SqlCommand sqlCommand6 = new SqlCommand("select AVG(PerMaas) From Tbl_Personel", SqlConnection);
            SqlDataReader sqlDataReader5 = sqlCommand6.ExecuteReader();
            while (sqlDataReader5.Read())
            {
                LblOrtalamaMaas.Text = sqlDataReader5[0].ToString();    
            }
            SqlConnection.Close();
        }
    }
}
