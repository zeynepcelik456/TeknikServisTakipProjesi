using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisProjesi.formlar
{
    public partial class frmarızalıürün : Form
    {
        public frmarızalıürün()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void frmarızalıürün_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARİ = x.TBLCARİ.AD +" "+ x.TBLCARİ.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD +" "+ x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl27.Text = db.TBLURUNKABUL.Count(x=>x.URUNDURUM==true).ToString();
            labelControl23.Text = db.TBLURUNKABUL.Count(x=>x.URUNDURUM==false).ToString();
            labelControl3.Text = db.TBLURUN.Count().ToString();
            labelControl25.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            labelControl7.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
            labelControl5.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor").ToString();

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DNNFR5;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY,COUNT(*)  FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            formlar.urunler.ArızalıUrunDetay fr = new urunler.ArızalıUrunDetay();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }
    }
}
