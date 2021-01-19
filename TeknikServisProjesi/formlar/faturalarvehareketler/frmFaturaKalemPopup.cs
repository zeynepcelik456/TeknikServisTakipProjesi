using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisProjesi.formlar.faturalarvehareketler
{
    public partial class frmFaturaKalemPopup : Form
    {
        public frmFaturaKalemPopup()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public int id;
        private void frmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLFATURADETAY
                                       select new
                                       {
                                           x.FATURAID,
                                           x.URUN,
                                           x.ADET,
                                           x.FIYAT,
                                          
                                       }).Where(x => x.FATURAID == id).ToList();

            gridControl2.DataSource = db.TBLFATURABİLGİ.Where(x => x.ID == id).ToList();
        }
    }
}
