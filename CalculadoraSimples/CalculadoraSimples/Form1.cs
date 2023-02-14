namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();   //Limpa o texto do TextBox
            txtX.Clear();       //Limpa o texto do TextBox
            txtY.Clear();       //Limpa o texto do TextBox
            txtX.Focus();       //Coloca o foco do cursor no txtX
            rdbSomar.Checked = true;    //Deixa selecionado o botão de somar
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, y, total;     //Declaração das variáveis

            //Entrada de dados
            //Validação de dados

            //Verifica se o que foi digitado em txtX é número. Também faz validação se o txtX está vazio
            if (double.TryParse(txtX.Text, out x) == false)
            {
                //Adiciona o botão OK e o ícone de informação do MessaBox
                MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtX.Clear();   //Limpa o texto do TextBox
                txtX.Focus();   //Coloca o foco do cursor no TextBox
                return;     //sai da subrotina, não executa o código que está abaixo
            }

            //Verifica se o que foi digitado em txtY é número. Também faz validação se o txtY está vazio
            if (double.TryParse(txtY.Text, out y) == false)
            {
                MessageBox.Show("Informe um valor válido", "Calculadora",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtY.Clear();   //limpa o texto do TextBox
                txtY.Focus();   //coloca o foco do cursor no TextBox
                return ;    //sai da sub-rotina, não executa o código que está abaixo
            }

            //Processamento
            //Testa na estrutura condicional qual RadioButton está selecionado

            if(rdbSomar.Checked == true)
            {
                total = x + y;
            }
            else if(rdbSubtrair.Checked == true)
            {
                total = x - y;
            }
            else if(rdbMultiplicar.Checked == true)
            {
                total = x* y;
            }
            else
            {
                //Verifica se está sendo realizada divisão por zero
                if(y == 0)
                {
                    txtTotal.Text = "Divisão por zero";
                    return;     //sai da sub-rotina, não executa o código que está abaixo
                }
                total = x / y;
            }
            //Apresenta a saída de dados convertendo para String

            txtTotal.Text = total.ToString();
        }
    }
}