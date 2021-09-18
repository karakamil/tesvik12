﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tesvik10
{
    public partial class Referanslar : Form
    {
        public Referanslar()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-89G3BRQ\SQLEXPRESS;Initial Catalog=TesvikData;Integrated Security=True");

        public void verilerigetir(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void Referanslar_Load(object sender, EventArgs e)
        {
            verilerigetir("select referansid as ID,referansadsoyad as ADI_SOYADI,reffirmaunvan as FİRMA_UNVAN,refeposta AS EPOSTA,reftelefon as TELEFON,refadres as ADRES, refil as İL, refilce as İLCE,refnotlar1 as NOT1, refnotlar2 as NOTT from ReferansBilgileri");

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string referansid = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string referansadsoyad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string reffirmaunvan = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string refeposta= dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string reftelefon = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string refadres = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string refil = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string refilce = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string refnotlar1 = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();
            string refnotlar2 = dataGridView1.Rows[secilialan].Cells[9].Value.ToString();

            lblrefno.Text = referansid.ToString().Trim();
            txtrefadsoyad.Text = referansadsoyad.ToString().Trim();
            txtreffirma.Text = reffirmaunvan.ToString().Trim();
            txteposta.Text = refeposta.ToString().Trim();
            txtreftelefon.Text = reftelefon.ToString().Trim();
            rcbadres.Text = refadres.ToString().Trim();
            txtrefil.Text = refil.ToString().Trim();
            txtrefilce.Text = refilce.ToString().Trim();
            rcbnot1.Text = refnotlar1.ToString().Trim();
            rcbnot2.Text = refnotlar2.ToString().Trim();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            tabloyutemizle();
        }
        public void tabloyutemizle()
        {
            lblrefno.Text = "";
            txtrefadsoyad.Text = "";
            txtreffirma.Text = "";
            txteposta.Text = "";
            txtreftelefon.Text = "";
            rcbadres.Text = "";
            txtrefil.Text = "";
            txtrefilce.Text = "";
            rcbnot1.Text = "";
            rcbnot2.Text = "";
            chkbxpasif.Checked = false;
        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string durum = (chkbxpasif.Checked = true) ? "Pasif" : "Aktif";
            baglan.Open();
            if (lblrefno.Text == "-")
            {
                SqlCommand ekle = new SqlCommand("INSERT INTO [ReferansBilgileri] (referansadsoyad ,reffirmaunvan,refeposta ,reftelefon,refadres, refil, refilce,refnotlar1, refnotlar2,aktifpasif) values (@adi,@firma,@eposta,@telefon,@adres,@il,@ilce,@not1,@not2,@durum)",baglan);

                ekle.Parameters.AddWithValue("@adi", txtrefadsoyad.Text.ToString().Trim());
                ekle.Parameters.AddWithValue("@firma", txtreffirma.Text.ToString().Trim());
                ekle.Parameters.AddWithValue("@eposta", txteposta.Text.ToString().Trim());
                ekle.Parameters.AddWithValue("@telefon", txtreftelefon.Text.ToString().Trim());
                ekle.Parameters.AddWithValue("@adres", rcbadres.Text.ToString().Trim());
                ekle.Parameters.AddWithValue("@il", txtrefil.Text.ToString().Trim());
                ekle.Parameters.AddWithValue("@ilce", txtrefilce.Text.ToString().Trim());
                ekle.Parameters.AddWithValue("@not1", rcbnot1.Text.ToString().Trim());
                ekle.Parameters.AddWithValue("@not2", rcbnot2.Text.ToString().Trim());
                ekle.Parameters.AddWithValue("@durum", durum.ToString().Trim());

                ekle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı");
            }
            
                else
            {
                    SqlCommand guncelle = new SqlCommand("update ReferansBilgileri set referansadsoyad='" + txtrefadsoyad.Text + "' ,reffirmaunvan='" + txtreffirma.Text + "',refeposta='" + txteposta.Text + "' ,reftelefon='" + txtreftelefon.Text + "',refadres='" + rcbadres.Text + "', refil='" + txtrefil.Text + "', refilce='" + txtrefilce.Text + "',refnotlar1='" + rcbnot1.Text + "', refnotlar2='" + rcbnot2.Text + "',aktifpasif=@durum where referansid ='" + lblrefno.Text + "'", baglan);

                guncelle.Parameters.AddWithValue("@durum", durum.ToString().Trim());

                guncelle.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme Başarılı");
             }
            baglan.Close();
            tabloyutemizle();
            verilerigetir("select referansid as ID,referansadsoyad as ADI_SOYADI,reffirmaunvan as FİRMA_UNVAN,refeposta AS EPOSTA,reftelefon as TELEFON,refadres as ADRES, refil as İL, refilce as İLCE,refnotlar1 as NOT1, refnotlar2 as NOTT from ReferansBilgileri");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Silinecektir", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                baglan.Open();
                int id = Convert.ToInt32(lblrefno.Text);
                SqlCommand sil = new SqlCommand("delete from ReferansBilgileri where referansid='" + id + "'", baglan);
                sil.ExecuteNonQuery();
                verilerigetir("select referansid as ID,referansadsoyad as ADI_SOYADI,reffirmaunvan as FİRMA_UNVAN,refeposta AS EPOSTA,reftelefon as TELEFON,refadres as ADRES, refil as İL, refilce as İLCE,refnotlar1 as NOT1, refnotlar2 as NOTT from ReferansBilgileri");
                tabloyutemizle();
            }
        }
    }
    
}
