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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void listele()
        {

            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.DEPARTMAN,
                               u.MAİL,
                               u.TELEFON

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listele();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void bynKaydet_Click(object sender, EventArgs e)
        {  
            TBLPERSONEL p = new TBLPERSONEL();
            if (txtAd.Text.Length >= 0 && txtSoyad.Text.Length >= 0 && txtMail.Text.Length >= 0 && txtTel.Text.Length >= 0 && txtId.Text.Length >= 0 && lookUpEdit1.Text.Length >= 0)
            {
                p.AD = txtAd.Text;
                p.SOYAD = txtSoyad.Text;
                p.TELEFON = txtTel.Text;
                p.MAİL = txtMail.Text;
                p.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            }
                
            db.TBLPERSONEL.Add(p);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        { 
            if(txtAd.Text.Length>=0 && txtSoyad.Text.Length >= 0 && txtMail.Text.Length >= 0 && txtTel.Text.Length >= 0 && txtId.Text.Length >= 0 && lookUpEdit1.Text.Length >= 0)
            {
                txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                txtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
                txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString();
                txtMail.Text = gridView1.GetFocusedRowCellValue("MAİL").ToString();
                txtTel.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();

            }
          
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var g = db.TBLPERSONEL.Find(id);
            if(txtAd.Text.Length >= 0 && txtSoyad.Text.Length >= 0 && txtMail.Text.Length >= 0 && txtTel.Text.Length >= 0 && txtId.Text.Length >= 0 && lookUpEdit1.Text.Length >= 0)
            {
                g.AD = txtAd.Text;
                g.SOYAD = txtSoyad.Text;
                g.MAİL = txtMail.Text;
                g.TELEFON = txtTel.Text;
                g.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            }
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();


        }
    }
}
