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
    public partial class frmFaturaKalemDetay : Form
    {
        public frmFaturaKalemDetay()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void frmFaturaKalemDetay_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFaturaId.Text);

            var deger = (from x in db.TBLFATURADETAY
                         select new
                         {
                             x.FATURADETAYID,
                             x.URUN,
                             x.ADET,
                             x.FIYAT,
                             x.TUTAR,
                             x.FATURAID

                         }).Where(x => x.FATURAID == id);
            gridControl1.DataSource = deger.ToList();

           
        }
    }
}
