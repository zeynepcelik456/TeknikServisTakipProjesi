using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisProjesi.formlar.Anasayfa
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK
                                       }).Where(x => x.STOK < 30).ToList();

            gridControl4.DataSource = (from x in db.TBLCARİ
                                       select new
                                       {
                                           AD = x.AD + " " + x.SOYAD,
                                           x.IL
                                       }).ToList();

            gridControl2.DataSource = db.URUNKATEGORI().ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.TARİH)
                        where (x.TARİH == bugun)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         });
           
           //int i = 1;
           //while(i <=5)
           //    {
           //     string konu = db.TBLILETISIM.First(x => x.ID == i).KONU;
           //     string ad = db.TBLILETISIM.First(x => x.ID == i).ADSOYAD;
           //     label[i] = new Label();
           //     label[i].Name = "label" + i.ToString();
           //    gr
           //     label[i].Top = i * 40;
           //     label[i].Left = 10;
               
           //     label[i].Text = konu + "-" + ad;
           //     i++;
           // }


        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
