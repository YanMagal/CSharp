namespace Variáveis
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnInteiros_Click(object sender, EventArgs e)
        {
            int a, b, soma;

            a = Int32.Parse(txtA.Text);
            b= Int32.Parse(txtB.Text);

            soma = a + b;

            txtResultado.Text = soma.ToString();
        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            double a, b, soma;

            a= Convert.ToDouble(txtA.Text);
            b= Double.Parse(txtB.Text);

            soma= a+b;

            txtResultado.Text= soma.ToString();
        }
    }
}