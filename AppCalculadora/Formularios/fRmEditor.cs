using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace AppCalculadora.Formularios
{
    public partial class fRmEditor : Form
    {
        Boolean saved;
        string texto = "";
        string path = "";
        int contadorpalabras = 0;
        int contadorletras=0;
        public fRmEditor()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdEditor.FileName))
                {
                    rchEditar.Text = File.ReadAllText(ofdEditor.FileName);
                }
            }

        }

        private void rchEditar_TextChanged(object sender, EventArgs e)
        {
             texto = rchEditar.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            contadorpalabras = palabras.Length;
            contadorletras = texto.Length;
            this.stsLPalabras.Text = $"Numero de palabras:{contadorpalabras}";
        }

        void guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = ofdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rchEditar.Text);
                }
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rchEditar.Text);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchEditar.Clear();
            path = "";
            saved = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stsLPalabras_TextChanged(object sender, EventArgs e)
        {

        }

        private void stsLPalabras_Click(object sender, EventArgs e)
        {
           
            string[] parrafos = texto.Split(new char[] { 'n' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("Estadisticas:\n\nPalabras:"+" "+contadorpalabras+"\n\nCaracteres:"+texto.Length.ToString()
                +"\n\nParrafos:"+parrafos.Length.ToString(), "Contador de palabras");
        }
    }
}
