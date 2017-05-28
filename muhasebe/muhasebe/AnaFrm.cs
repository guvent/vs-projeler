using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class AnaFrm : Form
    {

        Form musteriler = new Form1(false);
        Form satislar = new Form2();
        Form urunler = new Form3();

        Form satisyap = new hsatis();
        
        

        public AnaFrm()
        {
            InitializeComponent();
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uygulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void satışlarıİnceleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satislar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satisyap.Show();
        }

        private void müşterilereGözatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriler.Show();
        }

        private void ürünleriİnceleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunler.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kapat();
            
        }

        private void satışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisyap.Show();
        }

        private void yeniMüşteriOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ymusteri = new Form1(true);
            ymusteri.Show();
            
        }

        private void ürünOluşturGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunler.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kapat();
            this.Enabled = false;
            
        }

        void kapat()
        {
            if (MessageBox.Show("Çıkış Yapmak İstiyor Musunuz? \nEğer Kaydedilmemiş İşlemleriniz Varsa İşlemler İptal Olacaktır.!",
                "Dikkat Edin..!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form hakkinda = new Hakkinda();
            hakkinda.Show();
        }

        private void kasiyerlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kasiyer = new Kasiyer();
            kasiyer.Show();
        }

        private void kasiyerGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
        }
    }
}
