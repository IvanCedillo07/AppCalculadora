namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                resultado = a + b;
                MessageBox.Show("El resultado es:" + resultado.ToString(), "Siztema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conversion de datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
            }
        }

        private void btnMultplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                resultado = a * b;
                MessageBox.Show("El resultado es:" + resultado.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conversion de datos");
                Reset();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
