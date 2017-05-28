using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void urunlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.urunlerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._MyDatabase_1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MyDatabase_1DataSet.urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this._MyDatabase_1DataSet.urunler);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; this.Hide();
        }
    }
}
