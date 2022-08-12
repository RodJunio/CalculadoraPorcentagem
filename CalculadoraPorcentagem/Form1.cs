namespace CalculadoraPorcentagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbPorcento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txbNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txbNumero.Text);
            b = int.Parse(txbPorcento.Text);
            int result = (a /100) * b;
            txtResultado.Text = result.ToString();
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double c, d;
            c = double.Parse(txtNumero2.Text);
            d = double.Parse(txtNumero3.Text);
            double result2 = (c / d) * 100;
            txtResultadoPorcento.Text = result2.ToString("0.00");

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultadoPorcento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}