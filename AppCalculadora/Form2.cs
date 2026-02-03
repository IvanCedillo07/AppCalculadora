using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 calcuSimple = new Form1();
            calcuSimple.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Burbuja = new Form3();
            Burbuja.Show();
        }
    }
}
