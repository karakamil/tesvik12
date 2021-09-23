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
            dataGirtAyrıntı.Columns[6].DefaultCellStyle.Format = "#,#.##";
            dataGirtAyrıntı.Columns[7].DefaultCellStyle.Format = "#,#.##";
            dataGirtAyrıntı.Columns[8].DefaultCellStyle.Format = "#,#.##";
            dataGirtAyrıntı.Columns[9].DefaultCellStyle.Format = "#,#.##";
            dataGirtAyrıntı.Columns[10].DefaultCellStyle.Format = "#,#.##";


            dataGirtAyrıntı.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGirtAyrıntı.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGirtAyrıntı.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGirtAyrıntı.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGirtAyrıntı.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGirtAyrıntı.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGirtAyrıntı.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGirtAyrıntı.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



        }

        public void donemBazliListele(string veriler)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGritAyOzet.DataSource = ds.Tables[0];
            dataGritAyOzet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGritAyOzet.Columns[1].DefaultCellStyle.Format = "#,#.##";
            dataGritAyOzet.Columns[2].DefaultCellStyle.Format = "#,#.##";

            dataGritAyOzet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGritAyOzet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGritAyOzet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        public void subeBazliListele(string veriler)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGritSubeOzet.DataSource = ds.Tables[0];
            dataGritSubeOzet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGritSubeOzet.Columns[2].DefaultCellStyle.Format = "#,#.##";
            dataGritSubeOzet.Columns[3].DefaultCellStyle.Format = "#,#.##";
            dataGritSubeOzet.Columns[4].DefaultCellStyle.Format = "#,#.##";
            dataGritSubeOzet.Columns[5].DefaultCellStyle.Format = "#,#.##";
            dataGritSubeOzet.Columns[6].DefaultCellStyle.Format = "#,#.##";

            dataGritSubeOzet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGritSubeOzet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGritSubeOzet.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGritSubeOzet.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGritSubeOzet.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
           

            SQLiteCommand cmbdonem = new SQLiteCommand("select * from DonemBilgisi",baglan);
            SQLiteDataReader dr1 = cmbdonem.ExecuteReader();
            while (dr1.Read())
            {
                cmbilk.Items.Add(dr1[3]);
                cmbson.Items.Add(dr1[3]);
            }
            baglan.Close();

            cmbilk.Text = "2017/02";
            cmbson.Text = "2021/09";



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

            subeBazliListele("SELECT sb.subeid as ID,sb.subeunvan, sum(Asg_Ucr_GV) as AsgUcrGV, sum(Asg_Ucr_Trk_icin_Matrah) as Trkn_Matrah, sum(Agi_Minumum) as AGİ, sum(gvTerkin)AS GV_TERKİN, sum(dvTerkin) as DV_TERKİN from HizmetListesi as hl INNER JOIN sube_bilgileri as sb  on sb.subeid = hl.subeid where sb.firmaid = '" + firmaid + "'  AND hl.donem BETWEEN '" + cmbilk.Text + "' and '" + cmbson.Text + "' and (Kanun_No = '00687' or Kanun_No = '01687' or Kanun_No = '17103' or Kanun_No = '27103') group by sb.subeunvan");

            donemBazliListele("SELECT Donem,  sum(gvTerkin)AS GV_TERKİN, sum(dvTerkin) as DV_TERKİN from HizmetListesi where firmaid='" + firmaid + "'  AND donem BETWEEN '" + cmbilk.Text + "' and '" + cmbson.Text + "' and  (Kanun_No = '00687' or Kanun_No = '01687' or Kanun_No = '17103' or Kanun_No = '27103') group by Donem");//sum(Asg_Ucr_GV) as AsgUcrGV, sum(Asg_Ucr_Trk_icin_Matrah) as Trkn_Matrah, sum(Agi_Minumum) as AGİ,

            detayLlistele("SELECT SgkNo as TcNo, Ad, Soyad, Kanun_No, Gun, Donem,Asg_Ucr_GV as AsgUcrGV, Asg_Ucr_Trk_icin_Matrah as Trkn_Mtrh, Agi_Minumum as AGİ, gvTerkin, dvTerkin from HizmetListesi where firmaid='" + firmaid + "' AND donem BETWEEN '" + cmbilk.Text + "' and '" + cmbson.Text + "' and  (Kanun_No like '00687' or Kanun_No like '01687' or Kanun_No like '17103' or Kanun_No like '27103')");//Year as YIL, Month as AY,
            //SUBE BAZLI TABLO 
            double gvst = 0;
            double dvst = 0;
            for (int i = 0; i < dataGritSubeOzet.Rows.Count; i++)
            {
                gvst += Convert.ToDouble(dataGritSubeOzet.Rows[i].Cells["GV_TERKİN"].Value);
                dvst += Convert.ToDouble(dataGritSubeOzet.Rows[i].Cells["DV_TERKİN"].Value);
            }
            lblgvst.Text = gvst.ToString("0,0.00");
            lbldvst.Text = dvst.ToString("0,0.00");
            //DONEMBAZLI LİSTE
            int gvdn = 0;
            int dvdn = 0;
            for (int i = 0; i < dataGritAyOzet.Rows.Count; i++)
            {
                gvdn += Convert.ToInt32(dataGritAyOzet.Rows[i].Cells["GV_TERKİN"].Value);
                dvdn += Convert.ToInt32(dataGritAyOzet.Rows[i].Cells["DV_TERKİN"].Value);
            }
            lbldnmgv.Text = gvdn.ToString("0,0.00");
            lbldnmdv.Text = dvdn.ToString("0,0.00");
            // DETAY  LİSTE
            int gvdt = 0;
            int dvdt = 0;
            for (int i = 0; i < dataGirtAyrıntı.Rows.Count; i++)
            {
                gvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["gvTerkin"].Value);
                dvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["dvTerkin"].Value);
            }
            lbldetaygv.Text = gvdt.ToString("0,0.00");
            lbldetaydv.Text = dvdt.ToString("0,0.00");
        }


        


        private void dataGritSubeOzet_Click(object sender, EventArgs e)
        {
            int firmaid = Convert.ToInt32(lblfirmano.Text);
            int secim = dataGritSubeOzet.SelectedCells[0].RowIndex;
            string subeid = dataGritSubeOzet.Rows[secim].Cells[0].Value.ToString().Trim(); 
            donemBazliListele("SELECT Donem, sum(gvTerkin)AS GV_TERKİN, sum(dvTerkin) as DV_TERKİN from HizmetListesi where firmaid='" + firmaid + "'  AND subeid='" + subeid + "'  AND donem BETWEEN '" + cmbilk.Text + "' and '" + cmbson.Text + "' and  (Kanun_No = '00687' or Kanun_No = '01687' or Kanun_No = '17103' or Kanun_No = '27103') group by Donem");//sum(Asg_Ucr_GV) as AsgUcrGV, sum(Asg_Ucr_Trk_icin_Matrah) as Trkn_Matrah, sum(Agi_Minumum) as AGİ, 

            detayLlistele("SELECT SgkNo as TcNo, Ad, Soyad, Kanun_No,Gun, Donem,Asg_Ucr_GV as AsgUcrGV, Asg_Ucr_Trk_icin_Matrah as Trkn_Mtrh, Agi_Minumum as AGİ, gvTerkin, dvTerkin from HizmetListesi where firmaid='" + firmaid + "'  AND subeid='" + subeid + "'  AND donem BETWEEN '" + cmbilk.Text + "' and '" + cmbson.Text + "' and (Kanun_No like '00687' or Kanun_No like '01687' or Kanun_No like '17103' or Kanun_No like '27103')");//Year as YIL, Month as AY, 
                                                                                                                                                                                                                                                                                                                                                                          //DONEMBAZLI LİSTE
            int gvdn = 0;
            int dvdn = 0;
            for (int i = 0; i < dataGritAyOzet.Rows.Count; i++)
            {
                gvdn += Convert.ToInt32(dataGritAyOzet.Rows[i].Cells["GV_TERKİN"].Value);
                dvdn += Convert.ToInt32(dataGritAyOzet.Rows[i].Cells["DV_TERKİN"].Value);
            }
            lbldnmgv.Text = gvdn.ToString("0,0.00");
            lbldnmdv.Text = dvdn.ToString("0,0.00");
            // DETAY  LİSTE

            int gvdt = 0;
            int dvdt = 0;
            for (int i = 0; i < dataGirtAyrıntı.Rows.Count; i++)
            {
                gvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["gvTerkin"].Value);
                dvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["dvTerkin"].Value);
            }
            lbldetaygv.Text = gvdt.ToString("0,0.00");
            lbldetaydv.Text = dvdt.ToString("0,0.00");
        }

        private void dataGritAyOzet_Click(object sender, EventArgs e)
        {
            int firmaid = Convert.ToInt32(lblfirmano.Text);
            int secim1 = dataGritSubeOzet.SelectedCells[0].RowIndex;
            string subeid = dataGritSubeOzet.Rows[secim1].Cells[0].Value.ToString().Trim();

            int secim = dataGritAyOzet.SelectedCells[0].RowIndex;
            string donem = dataGritAyOzet.Rows[secim].Cells[0].Value.ToString().Trim();

            detayLlistele("SELECT SgkNo as TcNo, Ad, Soyad, Kanun_No,Gun, Donem,Asg_Ucr_GV as AsgUcrGV, Asg_Ucr_Trk_icin_Matrah as Trkn_Mtrh, Agi_Minumum as AGİ, gvTerkin, dvTerkin from HizmetListesi where firmaid='" + firmaid + "'  AND subeid='" + subeid + "'  AND donem = '"+donem+"' and donem BETWEEN '" + cmbilk.Text + "' and '" + cmbson.Text + "' and  (Kanun_No like '00687' or Kanun_No like '01687' or Kanun_No like '17103' or Kanun_No like '27103')");//Year as YIL, Month as AY, 

            // DETAY  LİSTE
            int gvdt = 0;
            int dvdt = 0;
            for (int i = 0; i < dataGirtAyrıntı.Rows.Count; i++)
            {
                gvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["gvTerkin"].Value);
                dvdt += Convert.ToInt32(dataGirtAyrıntı.Rows[i].Cells["dvTerkin"].Value);
            }
            lbldetaygv.Text = gvdt.ToString("0,0.00");
            lbldetaydv.Text = dvdt.ToString("0,0.00");
        }
    }
}
