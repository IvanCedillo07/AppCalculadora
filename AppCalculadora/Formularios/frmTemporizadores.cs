using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;//Para usar input Box
using System.Media;
using CSCore.SoundOut;

namespace AppCalculadora.Formularios
{
    
    public partial class frmTemporizadores : Form
    {
        string alarma1 = "";
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToShortTimeString();
            if (lbHora.Text == alarma1)
            {
                SoundPlayer alarma = new SoundPlayer(@"C:\Users\newsa\OneDrive\Documentos\C#\AppCalculadora\AppCalculadora\Sonidos\pacman-dies.wav");
                alarma.Play();
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la hora:","Sistema","00:00:00 x.x");
        }
    }
}
