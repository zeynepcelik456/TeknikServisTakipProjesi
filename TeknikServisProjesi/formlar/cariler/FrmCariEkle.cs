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
    public partial class FrmCariEkle_ : Form
    {
        public FrmCariEkle_()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void bynKaydet_Click(object sender, EventArgs e)
        {
            TBLCARİ c = new TBLCARİ();
            c.AD = txtAd.Text;
            c.SOYAD = txtSoyad.Text;
            c.TELEFON = txtTelefon.Text;
            c.MAIL = txtMail.Text;
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
        }
        int secilen;
        private void FrmCariEkle__Load(object sender, EventArgs e)
        {
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

        //private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        //{
        //    secilen = int.Parse(lookUpEdit2.EditValue.ToString());
        //    lookUpEdit1.Properties.DataSource = (from y in db.TBLILCELER select new

        //    {
        //        y.IlceID,
        //        y.Ilce,
        //        y.IlID,
        //    }
        //    ).Where(z=>z.IlID==secilen).ToList();
        //}
    }
}
