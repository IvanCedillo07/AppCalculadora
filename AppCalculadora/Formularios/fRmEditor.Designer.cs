namespace AppCalculadora.Formularios
{
    partial class fRmEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsEditor = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            stsEditor = new StatusStrip();
            stsLPalabras = new ToolStripStatusLabel();
            rchEditar = new RichTextBox();
            sfdEditor = new SaveFileDialog();
            ofdEditor = new OpenFileDialog();
            mnsEditor.SuspendLayout();
            stsEditor.SuspendLayout();
            SuspendLayout();
            // 
            // mnsEditor
            // 
            mnsEditor.ImageScalingSize = new Size(20, 20);
            mnsEditor.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            mnsEditor.Location = new Point(0, 0);
            mnsEditor.Name = "mnsEditor";
            mnsEditor.Size = new Size(800, 28);
            mnsEditor.TabIndex = 0;
            mnsEditor.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(187, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(187, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(187, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(187, 26);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(187, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // stsEditor
            // 
            stsEditor.ImageScalingSize = new Size(20, 20);
            stsEditor.Items.AddRange(new ToolStripItem[] { stsLPalabras });
            stsEditor.Location = new Point(0, 424);
            stsEditor.Name = "stsEditor";
            stsEditor.Size = new Size(800, 26);
            stsEditor.TabIndex = 1;
            stsEditor.Text = "statusStrip1";
            // 
            // stsLPalabras
            // 
            stsLPalabras.Name = "stsLPalabras";
            stsLPalabras.Size = new Size(64, 20);
            stsLPalabras.Text = "Palabras";
            stsLPalabras.Click += stsLPalabras_Click;
            stsLPalabras.TextChanged += stsLPalabras_TextChanged;
            // 
            // rchEditar
            // 
            rchEditar.Dock = DockStyle.Fill;
            rchEditar.Location = new Point(0, 28);
            rchEditar.Name = "rchEditar";
            rchEditar.Size = new Size(800, 396);
            rchEditar.TabIndex = 2;
            rchEditar.Text = "";
            rchEditar.TextChanged += rchEditar_TextChanged;
            // 
            // sfdEditor
            // 
            sfdEditor.Filter = "\"Archivos de Texto\"|*.txt";
            // 
            // ofdEditor
            // 
            ofdEditor.Filter = "\"Archivos de Texto\"|\".txt\"";
            // 
            // fRmEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rchEditar);
            Controls.Add(stsEditor);
            Controls.Add(mnsEditor);
            MainMenuStrip = mnsEditor;
            Name = "fRmEditor";
            Text = "fRmEditor";
            mnsEditor.ResumeLayout(false);
            mnsEditor.PerformLayout();
            stsEditor.ResumeLayout(false);
            stsEditor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsEditor;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private StatusStrip stsEditor;
        private RichTextBox rchEditar;
        private SaveFileDialog sfdEditor;
        private OpenFileDialog ofdEditor;
        private ToolStripStatusLabel stsLPalabras;
    }
}