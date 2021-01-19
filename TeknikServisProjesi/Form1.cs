using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        formlar.FrmUrunListeleme frm;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm == null || frm.IsDisposed)
            {
                frm = new formlar.FrmUrunListeleme();
                frm.MdiParent = this;
                frm.Show();
            }
        }


        formlar.FrmIstatıstık frmi;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmi == null || frmi.IsDisposed)
            {
                frmi = new formlar.FrmIstatıstık();
                frmi.MdiParent = this;
                frmi.Show();
            }
        }

        formlar.FrmKategori frmk;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmk == null || frmk.IsDisposed)
            {
                frmk = new formlar.FrmKategori();
                frmk.MdiParent = this;
                frmk.Show();
            }
        }

        formlar.frmcariiller frmc;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmc == null || frmi.IsDisposed)
            {
                frmc = new formlar.frmcariiller();
                frmc.MdiParent = this;
                frmc.Show();
            }
        }


        formlar.FrmMarkalar frmm;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmm == null || frmm.IsDisposed)
            {
                frmm = new formlar.FrmMarkalar();
                frmm.MdiParent = this;
                frmm.Show();
            }

        }

        formlar.FrmCariListesi frmcari;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmcari == null || frmcari.IsDisposed)
            {
                frmcari = new formlar.FrmCariListesi();
                frmcari.MdiParent = this;
                frmcari.Show();
            }
        }

        formlar.FrmDepartman frmd;
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmd == null || frmd.IsDisposed)
            {
                frmd = new formlar.FrmDepartman();
                frmd.MdiParent = this;
                frmd.Show();
            }


        }


        formlar.FrmPersonel frmp;
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmp == null || frmp.IsDisposed)
            {
                frmp = new formlar.FrmPersonel();
                frmp.MdiParent = this;
                frmp.Show();
            }


        }

        formlar.FrmKurlar frmkur;
        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmkur == null || frmkur.IsDisposed)
            {
                frmkur = new formlar.FrmKurlar();
                frmkur.MdiParent = this;
                frmkur.Show();
            }

        }

        formlar.FrmYoutube frmyoutube;
        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmyoutube == null || frmyoutube.IsDisposed)
            {
                frmyoutube = new formlar.FrmYoutube();
                frmyoutube.MdiParent = this;
                frmyoutube.Show();
            }

        }

        formlar.frmarızalıürün frmarıza;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmarıza == null || frmarıza.IsDisposed)
            {
                frmarıza = new formlar.frmarızalıürün();
                frmarıza.MdiParent = this;
                frmarıza.Show();
            }
        }



        formlar.frmNotlar frmnot;
        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmnot == null || frmnot.IsDisposed)
            {
                frmnot = new formlar.frmNotlar();
                frmnot.MdiParent = this;
                frmnot.Show();
            }
        }
        formlar.FrmSatisListesi frmsatıslis;
        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmsatıslis == null || frmsatıslis.IsDisposed)
            {
                frmsatıslis = new formlar.FrmSatisListesi();
                frmsatıslis.MdiParent = this;
                frmsatıslis.Show();
            }
        }

        formlar.FrmFaturaListesi frmfa;
        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmfa == null || frmfa.IsDisposed)
            {
                frmfa = new formlar.FrmFaturaListesi();
                frmfa.MdiParent = this;
                frmfa.Show();
            }
        }
        formlar.frmFaturaKalem frmka;
        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frmka == null || frmka.IsDisposed)
            {
                frmka = new formlar.frmFaturaKalem();
                frmka.MdiParent = this;
                frmka.Show();
            }
        }
        formlar.urunler.ArizaliUrunDetayList frmyf;
        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmyf == null || frmyf.IsDisposed)
            {
                frmyf = new formlar.urunler.ArizaliUrunDetayList();
                frmyf.MdiParent = this;
                frmyf.Show();
            }
        }
        formlar.faturalarvehareketler.frmFaturaKalemDetay frmkd;
        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmkd == null || frmkd.IsDisposed)
            {
                frmkd = new formlar.faturalarvehareketler.frmFaturaKalemDetay();
                frmkd.MdiParent = this;
                frmkd.Show();
            }
        }

        formlar.Anasayfa.FrmAnaSayfa frma;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (frma == null || frma.IsDisposed)
            {
                frma = new  formlar.Anasayfa.FrmAnaSayfa();
                frma.MdiParent = this;
                frma.Show();
            }
        }
        formlar.Anasayfa.FrmAnaSayfa frmb;
        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmb == null || frmb.IsDisposed)
            {
                frmb = new formlar.Anasayfa.FrmAnaSayfa();
                frmb.MdiParent = this;
                frmb.Show();
            }
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //formlar.YeniNot frmyeninot = new formlar.YeniNot();
            //frmyeninot.Show();


        }
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmDepartmanEkleme frmde = new formlar.FrmDepartmanEkleme();
            frmde.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.frmYeniUrun frm = new formlar.frmYeniUrun();
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.YeniKategori yk = new formlar.YeniKategori();
            yk.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmCariEkle_ frmc = new formlar.FrmCariEkle_();
            frmc.Show();
        }
        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.frmUrunSatis frmcs = new formlar.frmUrunSatis();
            frmcs.Show();

        }
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmQrKod frmqr = new formlar.FrmQrKod();
            frmqr.Show();

        }
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.frmYeniFatura frmyf = new formlar.frmYeniFatura();
            frmyf.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmArızalıUrunKaydı frmArızalıUrunKaydı = new formlar.FrmArızalıUrunKaydı();
            frmArızalıUrunKaydı.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.urunler.ArızalıUrunDetay frmyf = new formlar.urunler.ArızalıUrunDetay();
            frmyf.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Winword");
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Excel");
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
