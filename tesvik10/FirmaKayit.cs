using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace tesvik10
{
    public partial class FirmaKayit : Form
    {
        
        public FirmaKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-89G3BRQ\SQLEXPRESS;Initial Catalog=TesvikData;Integrated Security=True");

        private void FirmaKayit_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand doldur = new SqlCommand("select * from ReferansBilgileri", baglan);
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {
                cmbrefadsoyad.Items.Add(dr[1]);
            }
            baglan.Close();

            lblfirmano.Text = programreferans.firmaid.ToString();
            baglan.Open();
            SqlCommand arananfirma = new SqlCommand("select * from Hizli_Firma_Kayit where firmaid ='"+lblfirmano.Text+"'", baglan);
            SqlDataReader aranan = arananfirma.ExecuteReader();
            while(aranan.Read())
            {
                txtfrmno.Text = aranan[1].ToString();
                txtkisaunvan.Text = aranan[2].ToString();
                txtvd.Text = aranan[3].ToString();
                txtvn.Text = aranan[4].ToString();
                txtyetkili.Text = aranan[5].ToString();
                txtytkltelefon.Text = aranan[6].ToString();
                txtytkposta.Text = aranan[7].ToString();
                lblrefid.Text = aranan[8].ToString();
                cmbrefadsoyad.Text = aranan[9].ToString();
                txtreftelefon.Text = aranan[10].ToString();
                txtvdkullanici.Text = aranan[11].ToString();
                txtvdparola.Text = aranan[12].ToString();
                txtvdsifre.Text = aranan[13].ToString();
                rctxfirmnot.Text = aranan[14].ToString();
                if (aranan[15].ToString()=="Pasif")
                {
                    chkbxpasif.Checked = true;
                }
                else
                {
                    chkbxpasif.Checked = false;
                }
               // baglan.Close();
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string id = lblfirmano.Text;
            if (lblfirmano.Text== "")
            {
                
                SqlCommand ekle = new SqlCommand("Insert Into Hizli_Firma_Kayit(Firma_No,Firmakisaadi,Vd,Vn,Yetkiliadsoyad,Telefon,e_posta,Refid,Refadsoyad,Reftelefon,VdKullanici,VdParola,VdSifre,FirmaNot,aktifpasif) values ('" + txtfrmno.Text + "','" + txtkisaunvan.Text + "','" + txtvd.Text + "','" + txtvn.Text + "','" + txtyetkili.Text + "','" + txtytkltelefon.Text + "','" + txtytkposta.Text + "','" + lblrefid.Text + "','" + cmbrefadsoyad.Text + "','" + txtreftelefon.Text + "','" + txtvdkullanici.Text + "','" + txtvdparola.Text + "','" + txtvdsifre.Text + "','" + rctxfirmnot.Text + "','" + chkbxpasif.Text + "')", baglan);
                ekle.ExecuteNonQuery();
                
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {

                //int firmaid = Convert.ToInt32(lblfirmano.Text);
                SqlCommand guncelle = new SqlCommand("update Hizli_Firma_Kayit set Firma_No='" + txtfrmno.Text + "',Firmakisaadi='" + txtkisaunvan.Text + "',Vd='" + txtvd.Text + "',Vn='" + txtvn.Text + "',Yetkiliadsoyad='" + txtyetkili.Text + "',Telefon='" + txtytkltelefon.Text + "',e_posta='" + txtytkposta.Text + "',Refid='" + lblrefid.Text + "',Refadsoyad='" + cmbrefadsoyad.Text + "',Reftelefon='" + txtreftelefon.Text + "',VdKullanici='" + txtvdkullanici.Text + "',VdParola='" + txtvdparola.Text + "',VdSifre='" + txtvdsifre.Text + "',FirmaNot='" + rctxfirmnot.Text + "',aktifpasif='" + chkbxpasif.Text + "' where firmaid =" + lblfirmano.Text + "", baglan);
                guncelle.ExecuteNonQuery();

                MessageBox.Show("Firma Bilgileri Güncellendi");
            }
            baglan.Close();

        }

        private void cmbrefadsoyad_SelectedValueChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand doldur = new SqlCommand("select * from ReferansBilgileri where referansadsoyad like '"+ cmbrefadsoyad.Text +"'", baglan);
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {

                lblrefid.Text = (dr[0]).ToString();
                txtreftelefon.Text = (dr[4]).ToString();

            }
            baglan.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Silinecektir", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
            {
                baglan.Open();
                int id = Convert.ToInt32(lblfirmano.Text.Trim());
                SqlCommand komut = new SqlCommand("Delete from Hizli_Firma_Kayit where firmaid =(" + id + ")", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                formutemize();
            }
        }

        private void btnfirmabul_Click(object sender, EventArgs e)
        {

            txtfrmno.Text = "";
            txtkisaunvan.Text = "";
            txtvd.Text = "";
            txtvn.Text = "";
            txtyetkili.Text = "";
            txtytkltelefon.Text = "";
            txtytkposta.Text = "";
            lblrefid.Text = "";
            cmbrefadsoyad.Text = "";
            txtreftelefon.Text = "";
            txtvdkullanici.Text = "";
            txtvdparola.Text = "";
            txtvdsifre.Text =  "";
            rctxfirmnot.Text = "";

            FirmaAra frm = new FirmaAra();
            frm.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formutemize();
        }

        public void formutemize()
        {
            lblfirmano.Text = "";
            txtfrmno.Text = "";
            txtkisaunvan.Text = "";
            txtvd.Text = "";
            txtvn.Text = "";
            txtyetkili.Text = "";
            txtytkltelefon.Text = "";
            txtytkposta.Text = "";
            lblrefid.Text = "";
            cmbrefadsoyad.Text = "";
            txtreftelefon.Text = "";
            txtvdkullanici.Text = "";
            txtvdparola.Text = "";
            txtvdsifre.Text = "";
            rctxfirmnot.Text = "";
            chkbxpasif.Checked = false;
        }
    }
}
