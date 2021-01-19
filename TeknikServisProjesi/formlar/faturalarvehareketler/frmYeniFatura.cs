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
    public partial class frmYeniFatura : Form
    {
        public frmYeniFatura()
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
           
        }

        private void frmYeniFatura_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARİ
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }
    }
}
