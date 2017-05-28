using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class Kasiyer : Form
    {
        public Kasiyer()
        {
            InitializeComponent();
        }

        private void kasiyerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kasiyerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._MyDatabase_1DataSet1);

        }

        private void Kasiyer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MyDatabase_1DataSet1.kasiyer' table. You can move, or remove it, as needed.
            this.kasiyerTableAdapter.Fill(this._MyDatabase_1DataSet1.kasiyer);

        }
    }
}
