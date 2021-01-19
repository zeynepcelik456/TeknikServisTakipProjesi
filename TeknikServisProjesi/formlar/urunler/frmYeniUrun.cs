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
    public partial class frmYeniUrun : Form
    {
        public frmYeniUrun()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();


        private void frmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = (from x in db.TBLKATEGORİ
                                                 select new

                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = txtUrunAd.Text;
            t.MARKA = txtMarkaAd.Text;
            t.ALISFIYAT = decimal.Parse(txtAlis.Text);
            t.SATISFIYAT = decimal.Parse(txtSatis.Text);
            t.KATEGORI = byte.Parse(lookUpEdit2.EditValue.ToString());
            t.STOK = short.Parse(txtStok.Text);
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
