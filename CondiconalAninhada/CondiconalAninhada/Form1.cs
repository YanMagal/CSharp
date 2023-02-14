namespace CondiconalAninhada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int aluno1, aluno2;

            aluno1 = Convert.ToInt32(txtAluno1.Text);
            aluno2 = Convert.ToInt32(txtAluno2.Text);

            if (aluno1 == aluno2)
            {
                MessageBox.Show("As notas são iguais!");
            }
            else if (aluno2 > aluno1)
            {
                MessageBox.Show("Aluno2 venceu!");
            }
            else
            {
                MessageBox.Show("Aluno1 venceu!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}