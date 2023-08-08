namespace calculadora_form
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        char op = '\0';

        public Form1()
        {
            InitializeComponent();

        }

        private void cambioLCD(object sender, EventArgs e)
        {
            var cambio = ((Button)sender);

            if (LCDtxt.Text == "0")
                LCDtxt.Text = "";

            LCDtxt.Text += cambio.Text;
        }

        private void caracter(object sender, EventArgs e)
        {
            var oper = ((Button)sender);

            valor1 = Convert.ToDouble(LCDtxt.Text);
            op = Convert.ToChar(oper.Tag);

            LCDtxt.Text = "0";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(LCDtxt.Text);

            switch (op)
            {
                case '+': LCDtxt.Text = (valor1 + valor2).ToString(); break;
                case '-': LCDtxt.Text = (valor1 - valor2).ToString(); break;
                case '*': LCDtxt.Text = (valor1 * valor2).ToString(); break;
                case '/': if (valor2 == 0) { LCDtxt.Text = "Deja la loquera"; } else { LCDtxt.Text = (valor1 / valor2).ToString(); } break;
                case '%': LCDtxt.Text = (valor1 * (valor2 / 100)).ToString(); break;
                case '^': LCDtxt.Text = (Math.Pow(valor1, valor2)).ToString(); break;
                case '√': LCDtxt.Text = (Math.Sqrt(valor1)).ToString(); LCDtxt.Text = valor1.ToString(); break;
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            LCDtxt.Text = LCDtxt.Text.Substring(0, LCDtxt.TextLength - 1);
            if (LCDtxt.Text.Length < 1)
            {
                LCDtxt.Text = "0";
            }
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            LCDtxt.Text = "0";
            op = '\0';
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (!LCDtxt.Text.Contains('.'))
            {
                LCDtxt.Text += ".";
            }
        }
    }
}