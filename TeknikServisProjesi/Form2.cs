using DevExpress.XtraEditors;
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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMİN where x.KULLANICIAD == bunifuTextBox1.Text && x.SIFRE == bunifuTextBox2.Text select x;

            if (sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
