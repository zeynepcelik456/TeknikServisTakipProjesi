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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;

        void listele()
        {
            var degerler = from x in db.TBLCARİ
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                               x.IL,
                               x.ILCE
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {

            listele();
            labelControl29.Text = db.TBLCARİ.Count().ToString();
            labelControl23.Text = db.TBLCARİ.Select(x => x.IL).Distinct().Count().ToString();
            labelControl25.Text = db.TBLCARİ.Select(x => x.ILCE).Distinct().Count().ToString();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.IlID,
                                                     x.Il
                                                 }).ToList();

        }
        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit2.EditValue.ToString());
            lookUpEdit1.Properties.DataSource = (from y in db.TBLILCELER
                                                 select new

                                                 {
                                                     y.IlceID,
                                                     y.Ilce,
                                                     y.IlID,
                                                 }
            ).Where(z => z.IlID == secilen).ToList();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            lookUpEdit2.Text= gridView1.GetFocusedRowCellValue("IL").ToString();


        }
        private void bynKaydet_Click(object sender, EventArgs e)
        {
            TBLCARİ c = new TBLCARİ();
            c.AD = txtAd.Text;
            c.SOYAD = txtSoyad.Text;
            c.TELEFON = txtTelefon.Text;
            c.BANKA = txtBanka.Text;
            c.VERGIDAIRESI = txtVergiDaire.Text;
            c.VERGINO = txtVergiNo.Text;
            c.STATU = txtStat.Text;
            c.ADRES = txtAdres.Text;
            c.IL = lookUpEdit2.Text;
            c.ILCE = lookUpEdit1.Text;
            db.TBLCARİ.Add(c);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
             var t= db.TBLCARİ.Find(id);
            db.TBLCARİ.Remove(t);
            db.SaveChanges();
            MessageBox.Show("Cari Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLCARİ.Find(id);
            deger.AD = txtAd.Text;
            deger.SOYAD = txtSoyad.Text;
            deger.IL = lookUpEdit2.Text;
            deger.ILCE = lookUpEdit1.Text;
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
