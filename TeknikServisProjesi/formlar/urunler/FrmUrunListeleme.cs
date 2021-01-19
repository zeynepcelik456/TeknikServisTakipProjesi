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
    public partial class FrmUrunListeleme : Form
    {
        public FrmUrunListeleme()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void listele()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               KATEGORI=u.TBLKATEGORİ.AD,
                               u.MARKA,
                               u.ALISFIYAT,
                               u.SATISFIYAT,
                               u.STOK
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmUrunListeleme_Load(object sender, EventArgs e)
        {
            //Listeleme tolist
            // var degerler = db.TBLURUN.ToList();
            listele();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORİ
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();
        }

        private void bynKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = txtUrunAd.Text;
            t.MARKA = txtMarkaAd.Text;
            t.ALISFIYAT = decimal.Parse(txtAlis.Text);
            t.SATISFIYAT = decimal.Parse(txtSatis.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.DURUM = false;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //var degerler = db.TBLURUN.ToList();
            //gridControl1.DataSource = degerler;
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try {  txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                txtMarkaAd.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                txtSatis.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
                txtAlis.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
                txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
               lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORI").ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Hata");
            }
               

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = txtUrunAd.Text;
            deger.MARKA = txtMarkaAd.Text;
            deger.ALISFIYAT = decimal.Parse(txtAlis.Text);
            deger.SATISFIYAT = decimal.Parse(txtSatis.Text);
            deger.STOK = short.Parse(txtStok.Text);
            deger.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtUrunAd.Text ="";
            txtMarkaAd.Text = "";
            txtSatis.Text = "";
            txtAlis.Text = "";
            txtStok.Text ="";
            lookUpEdit1.Text="";
        }
    }
}
