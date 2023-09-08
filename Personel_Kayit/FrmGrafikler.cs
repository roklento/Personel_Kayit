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
    public partial class FrmGrafikler : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source=MSI;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // Grafik Sehirler
            SqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Select PerSehir, Count(*) From Tbl_Personel Group By PerSehir", SqlConnection);
            SqlDataReader reader = sqlCommand1.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(reader[0], reader[1]);
            }
            SqlConnection.Close();

            // Grafik Meslek-Maas
            SqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("Select PerMeslek, AVG(PerMaas) From Tbl_Personel Group By PerMeslek", SqlConnection);
            SqlDataReader reader2 = sqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(reader2[0], reader2[1]);
            }
            SqlConnection.Close();
        }
    }
}
