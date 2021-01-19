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
    public partial class frmFaturaKalem : Form
    {
        public frmFaturaKalem()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void listele()
        {
            var deger = from x in db.TBLFATURADETAY
                        select new
                        {
                            x.FATURADETAYID,
                            x.URUN,
                            x.ADET,
                            x.FIYAT,
                            x.TUTAR,
                            x.FATURAID

                        };
            gridControl1.DataSource = deger.ToList();
        }
        private void frmFaturaKalem_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void bynKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY f = new TBLFATURADETAY();
            f.URUN = txtUrun.Text;
            f.ADET = short.Parse(txtAdet.Text);
            f.FIYAT = decimal.Parse(txtFıyat.Text);
            f.TUTAR = decimal.Parse(txtTutar.Text);
            f.FATURAID = int.Parse(txtFaturaID.Text);
            db.TBLFATURADETAY.Add(f);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalemi Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID" +
                "").ToString();
            txtUrun.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
            txtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            txtFıyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
            txtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            txtFaturaID.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            db.TBLFATURADETAY.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalemi Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            deger.URUN = txtUrun.Text;
            deger.ADET = short.Parse(txtAdet.Text);
            deger.FIYAT = decimal.Parse(txtFıyat.Text);
            deger.TUTAR = decimal.Parse(txtTutar.Text);
            deger.FATURAID = int.Parse(txtFaturaID.Text);
           db.SaveChanges();
            MessageBox.Show("Fatura Kalemi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
