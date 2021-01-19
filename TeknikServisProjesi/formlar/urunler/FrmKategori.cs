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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void listele()
        {
            var degerler = from u in db.TBLKATEGORİ
                           select new
                           {
                               u.ID,
                               u.AD

                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void bynKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtAd.Text.Length <= 30)
            {
                TBLKATEGORİ t = new TBLKATEGORİ();
                t.AD = txtAd.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Girildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = byte.Parse(txtId.Text);
            var deger = db.TBLKATEGORİ.Find(id);
            db.TBLKATEGORİ.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = byte.Parse(txtId.Text);
            var deger = db.TBLKATEGORİ.Find(id);
            deger.AD = txtAd.Text;
            deger.ID = byte.Parse(txtId.Text);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtAd.Text = "";

        }
    }
}
