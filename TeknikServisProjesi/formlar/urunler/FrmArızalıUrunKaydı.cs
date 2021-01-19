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
    public partial class FrmArızalıUrunKaydı : Form
    {
        public FrmArızalıUrunKaydı()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = int.Parse(lookUpEdit2.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit1.EditValue.ToString());
            t.GELISTARIHI = DateTime.Parse(txtTarih.Text);
            t.URUNSERINO = txtSeriNo.Text;
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Başarıyla Kaydedildi.", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmArızalıUrunKaydı_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = (from x in db.TBLCARİ
                                                 select new

                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new

                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
