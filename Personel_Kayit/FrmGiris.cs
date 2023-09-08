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
    public partial class FrmGiris : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source=MSI;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Admin where KullaniciAd = @p1 and Sifre = @p2", SqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", Txtsifre.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if(reader.Read())
            {
                FrmAnaForm form = new FrmAnaForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre Girdiniz!");
            }
            SqlConnection.Close();
        }
    }
}
