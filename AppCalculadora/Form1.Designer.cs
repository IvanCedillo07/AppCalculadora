namespace AppCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            rdbSuma = new RadioButton();
            rdbResta = new RadioButton();
            rdbMulti = new RadioButton();
            rdbDivision = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 112);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "VARIABLE A:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChange;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 280);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 247);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "VARIABLE B:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(660, 133);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(685, 260);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDivision);
            groupBox1.Controls.Add(rdbMulti);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Location = new Point(372, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 236);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(67, 44);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(71, 24);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "SUMA";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(67, 89);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(72, 24);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "RESTA";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbMulti
            // 
            rdbMulti.AutoSize = true;
            rdbMulti.Location = new Point(67, 136);
            rdbMulti.Name = "rdbMulti";
            rdbMulti.Size = new Size(144, 24);
            rdbMulti.TabIndex = 2;
            rdbMulti.TabStop = true;
            rdbMulti.Text = "MULTIPLICACION";
            rdbMulti.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(67, 186);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(92, 24);
            rdbDivision.TabIndex = 3;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "DIVISION";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button btnCalcular;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton rdbDivision;
        private RadioButton rdbMulti;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
    }
}
