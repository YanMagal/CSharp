namespace Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSabores.Items.Add("Mussarela");
            cboSabores.Items.Add("Palmito");
            cboSabores.Items.Add("Atum");
            cboSabores.Items.Add("Calabresa");

            cboSabores.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboSabores.SelectedIndex = 0;

            cboSabores.Focus();

            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            rdbSemBorda.Checked = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string strSabor;

            string strPedido = null;

            strSabor = cboSabores.Text;

            if (string.IsNullOrEmpty(cboSabores.Text))
            {
                MessageBox.Show("Selecione um sabor de Pizza", "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSabores.Focus();
                return;
            }
            switch (strSabor)
            {
                case "Mussarela":
                    strPedido = "Mussarela";
                    break;
                case "Palmito":
                    strPedido = "Palmito";
                    break;
                case "Atum":
                    strPedido = "Atum";
                    break;
                case "Calabresa":
                    strPedido = "Calabresa";
                    break;
            }
            if (chkAzeitona.Checked)
            {
                strPedido = strPedido + "Com Azeitonas";
            }
            if (chkCebola.Checked)
            {
                strPedido = strPedido + "Com cebola";
            }
            if (rdbComBorda.Checked)
            {
                strPedido = strPedido + "Com Borda Recheada";
            }
            else
            {
                strPedido = strPedido + "Sem Borda";
            }
            MessageBox.Show(strPedido, "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}