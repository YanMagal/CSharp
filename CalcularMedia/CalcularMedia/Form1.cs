namespace CalcularMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);

            media = (nota1 + nota2 + nota3) /3;

            lblMedia.Text = media.ToString();

            if (media >= 7.0)
            {
                lblSitaçao.Text = "Aluno Aprovado!";
            }
            else
            {
                lblSitaçao.Text = "aluno Reprovado!";
            }
        }
    }
}