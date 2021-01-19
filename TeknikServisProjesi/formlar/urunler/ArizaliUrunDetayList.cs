using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisProjesi.formlar.urunler
{
    public partial class ArizaliUrunDetayList : Form
    {
        public ArizaliUrunDetayList()
        {
            InitializeComponent();
        }

        private void ArizaliUrunDetayList_Load(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            gridControl1.DataSource = (from x in db.TBLURUNTAKIP
                                       select new
                                       {
                                           x.TAKIPID,
                                           x.SERİNO,
                                           x.ACIKLAMA,
                                           x.TARIH
                                          
                                       }).ToList();


        }
    }
}
