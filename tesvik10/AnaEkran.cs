using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tesvik10
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnfirmakayit_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FirmaKayit firmakayit = new FirmaKayit();
            firmakayit.TopLevel = false;
            panel3.Controls.Add(firmakayit);//panele formu yükledik

            firmakayit.Show();
            firmakayit.Dock = DockStyle.Fill; // açılan formun paneli doldurması sağlanıyor
            firmakayit.BringToFront();//panelin üzerinde form en üste getiriliyor. 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            SubeKayit subekayit = new SubeKayit();
            subekayit.TopLevel = false;
            panel3.Controls.Add(subekayit);

            subekayit.Show();
            subekayit.Dock = DockStyle.Fill;
            subekayit.BringToFront();
                
        }
    }
}
