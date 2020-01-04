using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Kelime_Otomasyonu.Istatistikİslemleri
{
    public partial class Istatistik : DevExpress.XtraEditors.XtraForm


    {
        public Istatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglinti = new SqlConnection("Data Source=BEYZATAS;Initial Catalog=KelimeOtomasyonu;Integrated Security=True");

        private void Istatistik_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 140);

            baglinti.Open();
            SqlCommand komutg = new SqlCommand("Select *from tbl_Istatistik", baglinti);
            SqlDataReader read = komutg.ExecuteReader();

            while (read.Read())
            {
                cKelime.Series["Kelime"].Points.AddXY(int.Parse(read[0].ToString()), int.Parse(read[3].ToString()));
            }
            baglinti.Close();

            cKelime.Series["Kelime"].IsValueShownAsLabel = true;
        }
    }
}