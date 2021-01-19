using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisProjesi.formlar
{
    public partial class FrmIstatıstık : Form
    {
        public FrmIstatıstık()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmIstatıstık_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORİ.Count().ToString();
            labelControl7.Text = db.TBLURUN.Sum(x=>x.STOK).ToString();
            labelControl19.Text = (from x in db.TBLURUN
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();
            labelControl17.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();
            labelControl37.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            labelControl35.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            labelControl33.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            labelControl29.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
            labelControl25.Text = db.TBLURUNKABUL.Count().ToString();
            labelControl15.Text = db.MAKSKATEGORI().FirstOrDefault();
            labelControl27.Text=db.MARKSURUNMARKA().FirstOrDefault();
            labelControl5.Text= db.TBLURUN.Count(x => x.STOK < 30).ToString();

        }
    }
}
