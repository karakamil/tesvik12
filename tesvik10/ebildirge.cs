using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace tesvik10
{
    public partial class ebildirge : Form
    {
        public ebildirge()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-89G3BRQ\SQLEXPRESS;Initial Catalog=TesvikData;Integrated Security=True");

        public void verilerilistele(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void tahakkuklarigoster(string tahakkuklar)
        {
            SqlDataAdapter daa = new SqlDataAdapter(tahakkuklar, baglan);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            dataGridView2.DataSource = dss.Tables[0];
        }
        public void hizmetlistesinigoster(string hizmetlistesi)
        {
            SqlDataAdapter da = new SqlDataAdapter(hizmetlistesi, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void ebildirge_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand combobx = new SqlCommand("select * From Hizli_Firma_Kayit",baglan);//  where aktifpasif like'Aktif'
            SqlDataReader dr = combobx.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[2]);
            }
            baglan.Close();
       
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand frm = new SqlCommand("select * from Hizli_Firma_Kayit where Firmakisaadi like '"+comboBox1.Text.ToString()+"'", baglan);
            SqlDataReader da = frm.ExecuteReader();
            while (da.Read())
            {
                lblfirmano.Text = (da[0].ToString().Trim());
                lblyetkiliadsoyad.Text = (da[5].ToString().Trim());
                lbltelefon.Text = (da[6].ToString().Trim());

            }
            da.Close();
            baglan.Close();
            int subeid = Convert.ToInt32(lblfirmano.Text);
            verilerilistele("select subeid as ID,firmunvantam as FİRMA_UNVAN,subeunvan AS SUBE,sgkkullanici AS KULLANICI,sgkek AS EK,sgksistemsif AS SİSTEM_SİF,sgkisyerisif AS İSYERİ_SİF From sube_bilgileri where aktifpasif='Aktif' and subeid='" + subeid + "'");
            
            
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            string subeid = dataGridView1.Rows[secim].Cells[0].Value.ToString().Trim();
            string sgkkullanici = dataGridView1.Rows[secim].Cells[3].Value.ToString().Trim();
            string sgkek= dataGridView1.Rows[secim].Cells[4].Value.ToString().Trim();
            string sgksistem = dataGridView1.Rows[secim].Cells[5].Value.ToString().Trim();
            string sgkisyeri = dataGridView1.Rows[secim].Cells[6].Value.ToString().Trim();

            lblsubeid.Text = subeid.Trim();
            lblsgkkullanici.Text = sgkkullanici.Trim();
            lblek.Text = sgkek.Trim();
            lblsistemsif.Text = sgksistem.Trim();
            lblisyerisif.Text = sgkisyeri.Trim();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://ebildirge.sgk.gov.tr/EBildirgeV2/PG");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }

        private void btnthkkal_Click(object sender, EventArgs e)
        {
            // IWebDriver driver = new ChromeDriver();

            var path = Application.StartupPath;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory", path);
            chromeOptions.AddUserProfilePreference("intl.accept_languages", "tr");
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            var driver = new ChromeDriver(path, chromeOptions);

            string v = txtebldv2guvenlik.Text.ToString().Trim();
            string klnc = lblsgkkullanici.Text.ToString().Trim();
            string ek = lblek.Text.ToString().Trim();
            string sistem = lblsistemsif.Text.ToString().Trim();
            string isyeri = lblisyerisif.Text.ToString().Trim();

            //driver.Navigate().GoToUrl("https://ebildirge.sgk.gov.tr/EBildirgeV2/login/kullaniciIlkKontrollerGiris.action?username=" + klnc + "&isyeri_kod=" + ek + "&password=" + sistem + "&isyeri_sifre=" + isyeri + "&isyeri_guvenlik=" + v + "");

            //driver.Navigate().GoToUrl("https://ebildirge.sgk.gov.tr/EBildirgeV2/tahakkuk/tahakkukonaylanmisTahakkukDonemSecildi.action?hizmet_yil_ay_index=2&hizmet_yil_ay_index_bitis=3");

            //string v = textBox1.Text.ToString().Trim();
            driver.Navigate().GoToUrl("https://ebildirge.sgk.gov.tr/EBildirgeV2/login/kullaniciIlkKontrollerGiris.action?username=12178849190&isyeri_kod=084&password=32978025&isyeri_sifre=70272627&isyeri_guvenlik=" + v + "");
            driver.Navigate().GoToUrl("https://ebildirge.sgk.gov.tr/EBildirgeV2/tahakkuk/tahakkukonaylanmisTahakkukDonemSecildi.action?hizmet_yil_ay_index=2&hizmet_yil_ay_index_bitis=3");

            ReadOnlyCollection<IWebElement> tahakkukadet = driver.FindElements(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr"));

            //ilk önce veri tabanındaki ilgili şubeye kayıtlı olan daha önce indirilmiş tahakkuk bilgileri siliniyor
            baglan.Open();
            int subeid = Convert.ToInt32(lblsubeid.Text);
            SqlCommand thklarisil = new SqlCommand("delete from ilktahakkukbilgi where subeid='" + subeid + "' ", baglan);
            thklarisil.ExecuteNonQuery();
            baglan.Close();
            //tahakkuk bilgi datagirtview dolduruluyor 
            tahakkuklarigoster("select * from ilktahakkukbilgi where subeid='" + subeid + "'");

            //indirilen tahakkuklar için data set oluşturuloyr







            for (int i = 3; i < (tahakkukadet.Count) + 1; i++)
            {
                try
                {
                    baglan.Open();
                    SqlCommand thklarial = new SqlCommand("INSERT INTO [ilktahakkukbilgi] (firmaid,subeid,thkkukdonem,hzmtdonem,blgtur,bmahiyet,bkanun,bcalisan,bgun,spek,pdfindurm) values (@firmaid,@subeid,@donmay,@hizmetay,@bturu,@bmahiyet,@kanunno,@calisan,@gun,@spk,@pdf)", baglan);

                    ReadOnlyCollection<IWebElement> donemay = driver.FindElements(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[" + i + "]/td[1]"));
                    //*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[3]/td[1]
                    ReadOnlyCollection<IWebElement> hizmetay = driver.FindElements(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[" + i + "]/td[2]"));
                    ReadOnlyCollection<IWebElement> belgeturu = driver.FindElements(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[" + i + "]/td[3]"));
                    ReadOnlyCollection<IWebElement> belgemahiyeti = driver.FindElements(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[" + i + "]/td[4]"));
                    ReadOnlyCollection<IWebElement> kanunno = driver.FindElements(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[" + i + "]/td[5]"));
                    ReadOnlyCollection<IWebElement> calisan = driver.FindElements(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[" + i + "]/td[6]"));
                    ReadOnlyCollection<IWebElement> gun = driver.FindElements(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[" + i + "]/td[7]"));
                    ReadOnlyCollection<IWebElement> spek = driver.FindElements(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[" + i + "]/td[8]"));

                    IWebElement pdf = driver.FindElement(By.XPath("//*[@id=\"contentContainer\"]/div/table/tbody/tr/td/table/tbody/tr/td/div/table/tbody/tr[" + i + "]/td[10]/div/a[2]"));



                    // thklarial.Parameters.AddWithValue("@hizmetay", (hizmetay.ToString().Trim().Substring(0,hizmetay+7);



                    thklarial.Parameters.AddWithValue("@firmaid", Convert.ToInt32(lblfirmano.Text.Trim()));
                    thklarial.Parameters.AddWithValue("@subeid", Convert.ToInt32(lblsubeid.Text.Trim()));
                    thklarial.Parameters.AddWithValue("@donmay", donemay.First().Text);
                    thklarial.Parameters.AddWithValue("@hizmetay", hizmetay.First().Text);
                    thklarial.Parameters.AddWithValue("@bturu", belgeturu.First().Text);
                    thklarial.Parameters.AddWithValue("@bmahiyet", belgemahiyeti.First().Text);
                    thklarial.Parameters.AddWithValue("@kanunno", kanunno.First().Text);
                    thklarial.Parameters.AddWithValue("@calisan", calisan.First().Text);
                    thklarial.Parameters.AddWithValue("@gun", gun.First().Text);
                    string spekk = spek.ToString().Substring(0, spek.First().Text.ToString().Length - 3);
                    thklarial.Parameters.AddWithValue("@spk", spekk);
                    //thklarial.Parameters.AddWithValue("@pdf", pdf.First().Text);

                    pdf.Click();
                    baglan.Close();
                }
                catch (Exception)
                {

                    throw;
                }
                
            }


            tahakkuklarigoster("select * from ilktahakkukbilgi where subeid='" + subeid + "'");
        }

        private void tb6sgkisyeribilgi_Click(object sender, EventArgs e)
        {

            int subeid = Convert.ToInt32(lblsubeid.Text);
            hizmetlistesinigoster("select * from Hizmet_Listesi Where subeid="+subeid+"");
        }
    }
    
}
