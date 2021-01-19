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

namespace TeknikServisProjesi.formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();


            labelControl29.Text = db.TBLURUN.Count().ToString();
            labelControl27.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
            labelControl23.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.MARKA).FirstOrDefault();
            labelControl25.Text = db.MARKSURUNMARKA().FirstOrDefault();

            //Grafik1 kısmını doldurduk
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DNNFR5;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT MARKA,COUNT(*)  FROM TBLURUN GROUP BY MARKA", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();

            //GRAFİK 2 KISMI

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT TBLKATEGORİ.AD ,COUNT(*) FROM TBLURUN INNER JOIN TBLKATEGORİ ON TBLKATEGORİ.ID = TBLURUN.KATEGORI GROUP BY TBLKATEGORİ.AD", baglanti);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(dr1[0].ToString(), int.Parse(dr1[1].ToString()));
            }
            baglanti.Close();




        }

        private void labelControl1_Click(object sender, EventArgs e)
        {


        }

        private void panelControl14_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
