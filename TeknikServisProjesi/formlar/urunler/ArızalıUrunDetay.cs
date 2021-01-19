using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisProjesi.formlar.urunler
{
    public partial class ArızalıUrunDetay : Form
    {
        public ArızalıUrunDetay()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.TARIH = DateTime.Parse(txtTarih.Text);
            t.SERİNO = txtSeriNo.Text;
            t.ACIKLAMA = richTextBox1.Text; 
            db.TBLURUNTAKIP.Add(t);
           
           

            TBLURUNKABUL tb = new TBLURUNKABUL();
            int urunid = int.Parse(id);
            var deger = db.TBLURUNKABUL.Find(urunid);
            deger.URUNDURUMDETAY = comboBox1.Text;
            db.SaveChanges();

            MessageBox.Show("Arıza Detayları Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string id,serino;
        private void ArızalıUrunDetay_Load(object sender, EventArgs e)
        {
            txtSeriNo.Text = serino;
        }
    }
}
