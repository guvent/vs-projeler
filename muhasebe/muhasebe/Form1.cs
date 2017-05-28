using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class Form1 : Form
    {
        public bool yenimusteri = false;
        public Form1(bool yenikayit)
        {
            InitializeComponent();
            yenimusteri = yenikayit;
        }

        private void musterilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musterilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._MyDatabase_1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MyDatabase_1DataSet.musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this._MyDatabase_1DataSet.musteriler);

            if (yenimusteri)
            {
                musterilerBindingSource.AddNew();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!yenimusteri)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        


       

       
    }
}
