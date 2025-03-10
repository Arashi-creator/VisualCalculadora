namespace VisualCalculadora
{
    public partial class Calculadora : Form
    {
        public double Resultado { get; set; } 
        public double  Valor { get; set; }
        private Operacao OperacaoSelecioanda { get; set; }

        private enum Operacao
        {
            Soma,
            Subtraçao,
            Divisao,
            Multiplicacao,
        }
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {

        }

        private void btnTela_Click(object sender, EventArgs e)
        {

        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            
            btnTela.Text = ".";
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            btnTela.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            btnTela.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            btnTela.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            btnTela.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            btnTela.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            btnTela.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            btnTela.Text += "6";
        }
        private void btnSete_Click(object sender, EventArgs e)
        {
            btnTela.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            btnTela.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            btnTela.Text += "9";
        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnApagar_Click(object sender, EventArgs e)
        {

        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecioanda = Operacao.Divisao;
            Valor = double.Parse(btnDivisao.Text);
            btnTela.Text = "";
        }


        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecioanda = Operacao.Soma;
            Valor = double.Parse(btnSoma.Text);
            btnTela.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecioanda = Operacao.Subtraçao;
            Valor = double.Parse(btnSubtracao.Text);
            btnTela.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecioanda = Operacao.Multiplicacao;
            Valor = double.Parse(btnMultiplicacao.Text);
            btnTela.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecioanda)
            {
                case Operacao.Soma:
                    break;

                case Operacao.Subtraçao:
                    break;

                case Operacao.Divisao:
                    break;

                case Operacao.Multiplicacao:
                    break;
            }

        }
    }
}
