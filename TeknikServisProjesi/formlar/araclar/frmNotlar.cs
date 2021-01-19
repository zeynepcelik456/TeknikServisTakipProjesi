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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }

        void listele()
        {
            gridControl3.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl4.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void frmNotlar_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void bynKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = txtBaslik.Text;
            t.ICERIK = txtIcerik.Text;
            if(checkEdit1.Checked)
            {
                t.DURUM = true;
            }
            else
            {
                t.DURUM = false;
            }
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Notunuz Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtBaslik.Text = gridView3.GetFocusedRowCellValue("BASLIK").ToString();
            txtId.Text = gridView3.GetFocusedRowCellValue("ID").ToString();
            txtIcerik.Text = gridView3.GetFocusedRowCellValue("ICERIK").ToString();
            checkEdit1.Checked = false;
        }

        private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtBaslik.Text = gridView4.GetFocusedRowCellValue("BASLIK").ToString();
            txtId.Text = gridView4.GetFocusedRowCellValue("ID").ToString();
            txtIcerik.Text = gridView4.GetFocusedRowCellValue("ICERIK").ToString();
            checkEdit1.Checked = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var silinecekdeger =db.TBLNOTLARIM.Find(id);
            db.TBLNOTLARIM.Remove(silinecekdeger);
            db.SaveChanges();
            MessageBox.Show("Notunuz Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var gd = db.TBLNOTLARIM.Find(id);
            gd.BASLIK = txtBaslik.Text;
            gd.ICERIK = txtIcerik.Text;
            if (checkEdit1.Checked)
            {
                gd.DURUM = true;
            }
            else
            {
                gd.DURUM = false;
            }
            db.SaveChanges();
            MessageBox.Show("Notunuz Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
