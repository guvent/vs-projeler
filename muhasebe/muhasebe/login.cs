using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class login : Form
    {
        Form anaform = new AnaFrm();
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin Misiniz.?", "Çıkmak Üzere.!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            { Application.Exit(); }
        }

        private void login_Load(object sender, EventArgs e)
        {
            anaform.Show();
            anaform.Enabled = false;

            anaform.EnabledChanged += new EventHandler(anaform_EnabledChanged);

        }

        void anaform_EnabledChanged(object sender, EventArgs e)
        {
           
            this.Show();
         //   throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaform.Text = "Muhasebe Programı-  Kasiyer : " + textBox1.Text;
            anaform.Enabled = true;
            this.Hide();
        }
    }
}
