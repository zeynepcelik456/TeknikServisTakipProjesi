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
    public partial class frmcariiller : Form
    {
        public frmcariiller()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DNNFR5;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void frmcariiller_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLCARİ.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,count(*) from TBLCARİ group by IL",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
