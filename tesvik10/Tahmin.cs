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

        public void detayLlistele(string veriler)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGirtAyrıntı.DataSource = ds.Tables[0];
            dataGirtAyrıntı.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void donemBazliListele(string veriler)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGritAyOzet.DataSource = ds.Tables[0];
            dataGritAyOzet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void subeBazliListele(string veriler)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGritSubeOzet.DataSource = ds.Tables[0];
            dataGritSubeOzet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

            subeBazliListele("SELECT sb.subeid as ID,sb.subeunvan, sum(Asg_Ucr_GV) as AsgUcrGV, sum(Asg_Ucr_Trk_icin_Matrah) as Trkn_Matrah, sum(Agi_Minumum) as AGİ, sum(gvTerkin)AS GV_TERKİN, sum(dvTerkin) as DV_TERKİN from HizmetListesi as hl INNER JOIN sube_bilgileri as sb  on sb.subeid = hl.subeid where sb.firmaid = '" + firmaid + "'  AND(Kanun_No = '00687' or Kanun_No = '01687' or Kanun_No = '17103' or Kanun_No = '27103') group by sb.subeunvan");

            donemBazliListele("SELECT Donem,  sum(gvTerkin)AS GV_TERKİN, sum(dvTerkin) as DV_TERKİN from HizmetListesi where firmaid='" + firmaid + "'  AND (Kanun_No = '00687' or Kanun_No = '01687' or Kanun_No = '17103' or Kanun_No = '27103') group by Donem");//sum(Asg_Ucr_GV) as AsgUcrGV, sum(Asg_Ucr_Trk_icin_Matrah) as Trkn_Matrah, sum(Agi_Minumum) as AGİ,

            detayLlistele("SELECT SgkNo as TcNo, Ad, Soyad, Kanun_No, Gun, Donem,Asg_Ucr_GV as AsgUcrGV, Asg_Ucr_Trk_icin_Matrah as Trkn_Mtrh, Agi_Minumum as AGİ, gvTerkin, dvTerkin from HizmetListesi where firmaid='" + firmaid + "' and (Kanun_No like '00687' or Kanun_No like '01687' or Kanun_No like '17103' or Kanun_No like '27103')");//Year as YIL, Month as AY,
            //SUBE BAZLI TABLO 
            double gvst = 0;
            double dvst = 0;
            for (int i = 0; i < dataGritSubeOzet.Rows.Count; i++)
            {
                gvst += Convert.ToDouble(dataGritSubeOzet.Rows[i].Cells["GV_TERKİN"].Value);
                dvst += Convert.ToDouble(dataGritSubeOzet.Rows[i].Cells["DV_TERKİN"].Value);
            }
            lblgvst.Text = gvst.ToString();
            lbldvst.Text = dvst.ToString();
            //DONEMBAZLI LİSTE
            int gvdn = 0;
            int dvdn = 0;
            for (int i = 0; i < dataGritAyOzet.Rows.Count; i++)
            {
                gvdn += Convert.ToInt32(dataGritAyOzet.Rows[i].Cells["GV_TERKİN"].Value);
                dvdn += Convert.ToInt32(dataGritAyOzet.Rows[i].Cells["DV_TERKİN"].Value);
            }
            lbldnmgv.Text = gvdn.ToString();
            lbldnmdv.Text = dvdn.ToString();
            // DETAY  LİSTE
            int gvdt = 0;
            int dvdt = 0;
            for (int i = 0; i < dataGirtAyrıntı.Rows.Count; i++)
            {
                gvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["gvTerkin"].Value);
                dvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["dvTerkin"].Value);
            }
            lbldetaygv.Text = gvdt.ToString();
            lbldetaydv.Text = dvdt.ToString();
        }


        


        private void dataGritSubeOzet_Click(object sender, EventArgs e)
        {
            int firmaid = Convert.ToInt32(lblfirmano.Text);
            int secim = dataGritSubeOzet.SelectedCells[0].RowIndex;
            string subeid = dataGritSubeOzet.Rows[secim].Cells[0].Value.ToString().Trim(); 
            donemBazliListele("SELECT Donem, sum(gvTerkin)AS GV_TERKİN, sum(dvTerkin) as DV_TERKİN from HizmetListesi where firmaid='" + firmaid + "'  AND subeid='" + subeid + "'  AND (Kanun_No = '00687' or Kanun_No = '01687' or Kanun_No = '17103' or Kanun_No = '27103') group by Donem");//sum(Asg_Ucr_GV) as AsgUcrGV, sum(Asg_Ucr_Trk_icin_Matrah) as Trkn_Matrah, sum(Agi_Minumum) as AGİ, 

            detayLlistele("SELECT SgkNo as TcNo, Ad, Soyad, Kanun_No,Gun, Donem,Asg_Ucr_GV as AsgUcrGV, Asg_Ucr_Trk_icin_Matrah as Trkn_Mtrh, Agi_Minumum as AGİ, gvTerkin, dvTerkin from HizmetListesi where firmaid='" + firmaid + "'  AND subeid='" + subeid + "'  AND (Kanun_No like '00687' or Kanun_No like '01687' or Kanun_No like '17103' or Kanun_No like '27103')");//Year as YIL, Month as AY, 
                                                                                                                                                                                                                                                                                                                                                                          //DONEMBAZLI LİSTE
            int gvdn = 0;
            int dvdn = 0;
            for (int i = 0; i < dataGritAyOzet.Rows.Count; i++)
            {
                gvdn += Convert.ToInt32(dataGritAyOzet.Rows[i].Cells["GV_TERKİN"].Value);
                dvdn += Convert.ToInt32(dataGritAyOzet.Rows[i].Cells["DV_TERKİN"].Value);
            }
            lbldnmgv.Text = gvdn.ToString();
            lbldnmdv.Text = dvdn.ToString();
            // DETAY  LİSTE

            int gvdt = 0;
            int dvdt = 0;
            for (int i = 0; i < dataGirtAyrıntı.Rows.Count; i++)
            {
                gvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["gvTerkin"].Value);
                dvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["dvTerkin"].Value);
            }
            lbldetaygv.Text = gvdt.ToString();
            lbldetaydv.Text = dvdt.ToString();
        }

        private void dataGritAyOzet_Click(object sender, EventArgs e)
        {
            int firmaid = Convert.ToInt32(lblfirmano.Text);
            int secim1 = dataGritSubeOzet.SelectedCells[0].RowIndex;
            string subeid = dataGritSubeOzet.Rows[secim1].Cells[0].Value.ToString().Trim();

            int secim = dataGritAyOzet.SelectedCells[0].RowIndex;
            string donem = dataGritAyOzet.Rows[secim].Cells[0].Value.ToString().Trim();

            detayLlistele("SELECT SgkNo as TcNo, Ad, Soyad, Kanun_No,Gun, Donem,Asg_Ucr_GV as AsgUcrGV, Asg_Ucr_Trk_icin_Matrah as Trkn_Mtrh, Agi_Minumum as AGİ, gvTerkin, dvTerkin from HizmetListesi where firmaid='" + firmaid + "'  AND subeid='" + subeid + "'  AND Donem='" + donem + "'  AND (Kanun_No like '00687' or Kanun_No like '01687' or Kanun_No like '17103' or Kanun_No like '27103')");//Year as YIL, Month as AY, 

            // DETAY  LİSTE
            int gvdt = 0;
            int dvdt = 0;
            for (int i = 0; i < dataGirtAyrıntı.Rows.Count; i++)
            {
                gvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["gvTerkin"].Value);
                dvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["dvTerkin"].Value);
            }
            lbldetaygv.Text = gvdt.ToString();
            lbldetaydv.Text = dvdt.ToString();
        }
    }
}
