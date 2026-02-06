namespace AppCalculadora
{
    partial class Form3
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
            dgvDesordenado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dgvOrdenado = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).BeginInit();
            SuspendLayout();
            // 
            // dgvDesordenado
            // 
            dgvDesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesordenado.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvDesordenado.Location = new Point(26, 30);
            dgvDesordenado.Name = "dgvDesordenado";
            dgvDesordenado.RowHeadersWidth = 51;
            dgvDesordenado.Size = new Size(195, 394);
            dgvDesordenado.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Desordenado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // dgvOrdenado
            // 
            dgvOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvOrdenado.Location = new Point(585, 30);
            dgvOrdenado.Name = "dgvOrdenado";
            dgvOrdenado.RowHeadersWidth = 51;
            dgvOrdenado.Size = new Size(187, 394);
            dgvOrdenado.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ordenado";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(345, 187);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(129, 47);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "ORDENAR";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrdenar);
            Controls.Add(dgvOrdenado);
            Controls.Add(dgvDesordenado);
            Name = "Form3";
            Text = "Ordenamiento Burbuja";
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDesordenado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgvOrdenado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnOrdenar;
    }
}