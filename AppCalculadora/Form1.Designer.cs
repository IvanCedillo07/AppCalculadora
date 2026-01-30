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
            btnMultplicar = new Button();
            btnReset = new Button();
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
            btnCalcular.Location = new Point(493, 156);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "SUMA";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnMultplicar
            // 
            btnMultplicar.Location = new Point(488, 253);
            btnMultplicar.Name = "btnMultplicar";
            btnMultplicar.Size = new Size(141, 29);
            btnMultplicar.TabIndex = 5;
            btnMultplicar.Text = "MULTIPLICAR";
            btnMultplicar.UseVisualStyleBackColor = true;
            btnMultplicar.Click += btnMultplicar_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(491, 345);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnMultplicar);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button btnCalcular;
        private Button btnMultplicar;
        private Button btnReset;
    }
}
