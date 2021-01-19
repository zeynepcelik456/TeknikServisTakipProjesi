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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void listele()
        {
            var degerler = from x in db.TBLFATURABİLGİ
                           select new
                           {
                               x.ID,
                               x.SERI,
                               x.SIRANO,
                               x.TARIH,
                               x.SAAT,
                              x.VERGIDAIRE,
                               CARİ =  x.TBLCARİ.AD + " " + x.TBLCARİ.SOYAD,
                               PERSONEL =  x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD

                           };
            gridControl1.DataSource = degerler.ToList();

        }

        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            listele();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARİ
                                                 select new
                                                 {
                                                     x.ID,
                                                   AD=x.AD+" "+x.SOYAD
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void bynKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABİLGİ f = new TBLFATURABİLGİ();
            f.SERI = txtSeri.Text;
            f.SIRANO = txtSıraNo.Text;
            f.TARIH = DateTime.Parse(txtTarih.Text);
            f.SAAT = txtSaat.Text;
            f.VERGIDAIRE = txtVergi.Text;
            f.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            f.PERSONEL = byte.Parse(lookUpEdit2.EditValue.ToString());
            db.TBLFATURABİLGİ.Add(f);
            db.SaveChanges();
           
            MessageBox.Show("Fatura Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtSeri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            txtSıraNo.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            txtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            txtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            txtVergi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("CARİ").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger=db.TBLFATURABİLGİ.Find(id);
            db.TBLFATURABİLGİ.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLFATURABİLGİ.Find(id);
            deger.SERI = txtSeri.Text;
            deger.SIRANO = txtSıraNo.Text;
            deger.TARIH = DateTime.Parse(txtTarih.Text);
            deger.SAAT = txtSaat.Text;
            deger.VERGIDAIRE = txtVergi.Text;
            deger.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            deger.PERSONEL = byte.Parse(lookUpEdit2.EditValue.ToString());
           db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            formlar.faturalarvehareketler.frmFaturaKalemPopup fr = new faturalarvehareketler.frmFaturaKalemPopup();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
