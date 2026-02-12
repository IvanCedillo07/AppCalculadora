namespace AppCalculadora.Formularios
{
    partial class frmTemporizadores
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
            components = new System.ComponentModel.Container();
            lbHora = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            mnsAlarma = new MenuStrip();
            establecerToolStripMenuItem = new ToolStripMenuItem();
            alarma1ToolStripMenuItem = new ToolStripMenuItem();
            mnsAlarma.SuspendLayout();
            SuspendLayout();
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHora.Location = new Point(191, 99);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(298, 69);
            lbHora.TabIndex = 0;
            lbHora.Text = "00:00:00 x.x";
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Interval = 1000;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // mnsAlarma
            // 
            mnsAlarma.ImageScalingSize = new Size(20, 20);
            mnsAlarma.Items.AddRange(new ToolStripItem[] { establecerToolStripMenuItem });
            mnsAlarma.Location = new Point(0, 0);
            mnsAlarma.Name = "mnsAlarma";
            mnsAlarma.Size = new Size(719, 28);
            mnsAlarma.TabIndex = 1;
            mnsAlarma.Text = "menuStrip1";
            // 
            // establecerToolStripMenuItem
            // 
            establecerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alarma1ToolStripMenuItem });
            establecerToolStripMenuItem.Name = "establecerToolStripMenuItem";
            establecerToolStripMenuItem.Size = new Size(91, 24);
            establecerToolStripMenuItem.Text = "Establecer";
            // 
            // alarma1ToolStripMenuItem
            // 
            alarma1ToolStripMenuItem.Name = "alarma1ToolStripMenuItem";
            alarma1ToolStripMenuItem.Size = new Size(224, 26);
            alarma1ToolStripMenuItem.Text = "Alarma 1";
            alarma1ToolStripMenuItem.Click += alarma1ToolStripMenuItem_Click;
            // 
            // frmTemporizadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 235);
            Controls.Add(lbHora);
            Controls.Add(mnsAlarma);
            MainMenuStrip = mnsAlarma;
            Name = "frmTemporizadores";
            Text = "Reloj";
            mnsAlarma.ResumeLayout(false);
            mnsAlarma.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHora;
        private System.Windows.Forms.Timer tmrHora;
        private MenuStrip mnsAlarma;
        private ToolStripMenuItem establecerToolStripMenuItem;
        private ToolStripMenuItem alarma1ToolStripMenuItem;
    }
}