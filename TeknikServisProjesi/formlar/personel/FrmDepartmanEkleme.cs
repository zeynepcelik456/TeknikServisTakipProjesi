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
    public partial class FrmDepartmanEkleme : Form
    {
        public FrmDepartmanEkleme()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN d = new TBLDEPARTMAN();
            d.AD = txtAd.Text;
            db.TBLDEPARTMAN.Add(d);
            db.SaveChanges();
            MessageBox.Show("Departman" +
                " Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDepartmanEkleme_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
