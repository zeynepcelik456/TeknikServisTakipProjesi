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
    public partial class YeniKategori : Form
    {
        public YeniKategori()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (txtKategorıAd.Text != "" && txtKategorıAd.Text.Length <= 30)
            {
                TBLKATEGORİ t = new TBLKATEGORİ();
                t.AD = txtKategorıAd.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Girildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YeniKategori_Load(object sender, EventArgs e)
        {

        }
    }
}
