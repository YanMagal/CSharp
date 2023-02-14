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
            rdbSomar.Checked = true;    //Deixa selecionado o bot�o de somar
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, y, total;     //Declara��o das vari�veis

            //Entrada de dados
            //Valida��o de dados

            //Verifica se o que foi digitado em txtX � n�mero. Tamb�m faz valida��o se o txtX est� vazio
            if (double.TryParse(txtX.Text, out x) == false)
            {
                //Adiciona o bot�o OK e o �cone de informa��o do MessaBox
                MessageBox.Show("Informe um valor v�lido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtX.Clear();   //Limpa o texto do TextBox
                txtX.Focus();   //Coloca o foco do cursor no TextBox
                return;     //sai da subrotina, n�o executa o c�digo que est� abaixo
            }

            //Verifica se o que foi digitado em txtY � n�mero. Tamb�m faz valida��o se o txtY est� vazio
            if (double.TryParse(txtY.Text, out y) == false)
            {
                MessageBox.Show("Informe um valor v�lido", "Calculadora",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtY.Clear();   //limpa o texto do TextBox
                txtY.Focus();   //coloca o foco do cursor no TextBox
                return ;    //sai da sub-rotina, n�o executa o c�digo que est� abaixo
            }

            //Processamento
            //Testa na estrutura condicional qual RadioButton est� selecionado

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
                //Verifica se est� sendo realizada divis�o por zero
                if(y == 0)
                {
                    txtTotal.Text = "Divis�o por zero";
                    return;     //sai da sub-rotina, n�o executa o c�digo que est� abaixo
                }
                total = x / y;
            }
            //Apresenta a sa�da de dados convertendo para String

            txtTotal.Text = total.ToString();
        }
    }
}