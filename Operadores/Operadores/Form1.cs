namespace Operadores
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            int x, y;
            x= Convert.ToInt32(txtX.Text);

            y = ++x;

         MessageBox.Show("Y = " + y + "X = " + x, "Incremento Pré-fixado");
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            int x,y;
            x = Convert.ToInt32(txtX.Text);

            y= x++;

            MessageBox.Show("Y = " + y + "X = " + x , "Incremento Pós-fixado");
        }
    }
}