using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class hsatis : Form
    {
        int selected = 0;
        int adet = 1;

        public hsatis()
        {
            InitializeComponent();
        }

        private void hsatis_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(255,192,192);

            if (textBox1.Text != "")
            {
                urunlerBindingSource.Filter = "UrunKodu = '" + textBox1.Text + "' OR Barkod = '" + textBox1.Text + "'";
            }
            

            this.Text =  urunlerBindingSource.List.Count.ToString();


        }

        
        private void hsatis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MyDatabase_1DataSet.urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this._MyDatabase_1DataSet.urunler);

            tadet.Text = adet.ToString();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ekle();
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selected = e.ItemIndex;
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(selected.ToString());


        }

        private void tadet_TextChanged(object sender, EventArgs e)
        {
            int outs;

            if (!Int32.TryParse(tadet.Text, out outs)) {
                adet = 1;
                tadet.Text = adet.ToString();
            }
        }


        void ekle()
        {
            int item = 0;
            int itemno = 0;
            float tutar = 0;
            int ladet = 0;

            float.TryParse(fiyatTextBox.DataBindings.Control.Text, out tutar);

            int.TryParse(tadet.Text, out ladet);

            tutar = tutar * ladet;


            itemno = listView1.Items.Count + 1;

            if (urunlerBindingSource.List.Count == 1)
            {
                item = listView1.Items.Add(itemno.ToString()).Index;
                listView1.Items[item].SubItems.Add(textBox1.Text); // ürün kodu
                listView1.Items[item].SubItems.Add(urunAdiTextBox.DataBindings.Control.Text); // ürün adı
                listView1.Items[item].SubItems.Add(fiyatTextBox.DataBindings.Control.Text); // fiyat
                listView1.Items[item].SubItems.Add(tadet.Text); // adet
                listView1.Items[item].SubItems.Add(tutar.ToString()); // tutar
            }
            else if (urunlerBindingSource.List.Count < 1)
            {
                MessageBox.Show("Ürün Kaydı Hatalı veya Ürün Yok", "Ürün Kodu Yok.!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (urunlerBindingSource.List.Count > 1)
            {
                MessageBox.Show("Ürün Kaydı Hatalı veya Ürün Kodu Birden Fazla Girilmiş", "Ürün Hatası.!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            toplamhesap();

            adet = 1;
            tadet.Text = adet.ToString();
        }

        void cikar()
        {
            if (listView1.Items.Count > 0)
            {
                if (listView1.Items[selected].SubItems[4].Text != "")
                {
                    listView1.Items[selected].Remove();
                }
            }

            toplamhesap();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            tadet.Text = (++adet).ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (adet > 1)
            { tadet.Text = (--adet).ToString(); }
            
        }

        void tutarhesap()
        {
            float tutar = 0;
            int ladet = 0;

            float.TryParse(listView1.Items[selected].SubItems[3].Text, out tutar);

            int.TryParse(listView1.Items[selected].SubItems[4].Text, out ladet);

            tutar = tutar * ladet;

            listView1.Items[selected].SubItems[5].Text = tutar.ToString();
        }

        void toplamhesap()
        {
            int cnt = 0;

            string tutarlar;
                float itutarlar = 0;
                float ttutar = 0;

                if (listView1.Items.Count > 0)
                {
                    cnt = listView1.Items.Count;


                    for (int i = 0; i < cnt; i++)
                    {
                        tutarlar = listView1.Items[i].SubItems[5].Text;
                        float.TryParse(tutarlar, out itutarlar);

                        ttutar = ttutar + itutarlar;
                    }

                    textBox2.Text = ttutar.ToString();

                }
                else {

                    textBox2.Text = "";
                }
        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            int sadet = 0;

            if (listView1.Items.Count > 0)
            {
                if (listView1.Items[selected].SubItems[4].Text != "")
                {
                    int.TryParse(listView1.Items[selected].SubItems[4].Text, out sadet);


                        if (e.KeyValue == 107) { ++sadet; listView1.Items[selected].SubItems[4].Text = sadet.ToString(); tutarhesap(); }
            
                        if (e.KeyValue == 109 && sadet > 1)
                        { --sadet; listView1.Items[selected].SubItems[4].Text = sadet.ToString(); tutarhesap(); }

                }
            }

            if (e.KeyData == Keys.Delete) { cikar(); }

            toplamhesap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cikar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            iptal();

            this.Hide();
        }

        void iptal()
        {
            textBox1.Text = "";
            listView1.Items.Clear();
            toplamhesap();


        }

       
    }
}
