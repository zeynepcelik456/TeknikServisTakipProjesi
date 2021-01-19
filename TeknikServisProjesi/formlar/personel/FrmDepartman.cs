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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void listele()
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA
                              
                           };
            gridControl1.DataSource = degerler.ToList();

        }
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            listele();
            labelControl29.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl27.Text = db.TBLPERSONEL.Count().ToString();
        }

        private void bynKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Length <= 50 && txtAd.Text != "" && richTextBox1.Text.Length >= 1)
            {
                TBLDEPARTMAN d = new TBLDEPARTMAN();
                d.AD = txtAd.Text;
                d.ACIKLAMA = richTextBox1.Text;
                db.TBLDEPARTMAN.Add(d);
                db.SaveChanges();
                MessageBox.Show("Departman" +
                    " Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            if (richTextBox1.Text.Length >= 1 && richTextBox1.Text == null)
            {
                richTextBox1.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var dep=db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(dep);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var dep = db.TBLDEPARTMAN.Find(id);
            dep.AD = txtAd.Text;
            dep.ACIKLAMA = richTextBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
