using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] ordenado=new int[dgvDesordenado.RowCount-1];
            //Cargar el array con los datos del datagridview
            for(int i = 0; i <= dgvDesordenado.RowCount; i++)
            {
                ordenado[i] = Convert.ToInt32(dgvDesordenado.Rows[i].Cells[0].Value);
            }
        }
    }
}
