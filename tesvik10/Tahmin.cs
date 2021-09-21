using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace tesvik10
{
    public partial class Tahmin : Form
    {
        public Tahmin()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan = new SQLiteConnection(Baglanti.Baglan);

        public void subeDetaListele(string veriler)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGirtAyrıntı.DataSource = ds.Tables[0];
        }
        private void Tahmin_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SQLiteCommand combobx = new SQLiteCommand("select * From Hizli_Firma_Kayit", baglan);//  where aktifpasif like'Aktif'
            SQLiteDataReader dr = combobx.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[2]);
            }
            baglan.Close();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            baglan.Open();
            SQLiteCommand frm = new SQLiteCommand("select * from Hizli_Firma_Kayit where Firmakisaadi like '" + comboBox1.Text.ToString() + "'", baglan);
            SQLiteDataReader da = frm.ExecuteReader();
            while (da.Read())
            {
                lblfirmano.Text = (da[0].ToString().Trim());

            }
            da.Close();
            dataGirtAyrıntı.Columns.Clear();
            baglan.Close();
            int firmaid = Convert.ToInt32(lblfirmano.Text);
            subeDetaListele("SELECT SgkNo as TcNo, Ad, Soyad, Kanun_No,Year as YIL, Month as AY, Gun, Donem,Asg_Ucr_GV as AsgUcrGV, Asg_Ucr_Trk_icin_Matrah as Trkn_Matrah, Agi_Minumum, gvTerkin, dvTerkin from HizmetListesi where subeid='"+firmaid+"' and Kanun_No like '00687' or Kanun_No like '1687' or Kanun_No like '17103' or Kanun_No like '27103'");
        }

        private void btnaphlistele_Click(object sender, EventArgs e)
        {

    
        }
    }
}
