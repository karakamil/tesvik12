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
    public partial class KanuniParametre : Form
    {
        public KanuniParametre()
        {
            InitializeComponent();
        }
        SQLiteConnection baglan = new SQLiteConnection(Baglanti.Baglan);
        DataTable sgkara = new DataTable();

        DataView yilfiltrele()
        {
            DataView dv = new DataView();
            dv = sgkara.DefaultView;
            dv.RowFilter = "YIL like '" + txtyilfiltre + "'";
            return dv;

        }

        DataView donemfiltre ()
        {
            DataView dv = new DataView();

        }
        //Select asg_yil as YIL, asg_dönem as DONEM, asg_taban_ucr as ASGARİ_UCR, asg_tavan_ucr as TAVAN_UCR From yillik_taban_tavan_ucr
        public void sgkdonembilgiler(string sgkdonembilg)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select asg_yil as YIL, asg_dönem as DONEM, asg_taban_ucr as ASGARİ_UCR, asg_tavan_ucr as TAVAN_UCR From yillik_taban_tavan_ucr", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void KanuniParametre_Load(object sender, EventArgs e)
        {
            
        }
    }
}
