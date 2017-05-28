using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void satislarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.satislarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._MyDatabase_1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MyDatabase_1DataSet.satislar' table. You can move, or remove it, as needed.
            this.satislarTableAdapter.Fill(this._MyDatabase_1DataSet.satislar);

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; this.Hide();
        }
    }
}
