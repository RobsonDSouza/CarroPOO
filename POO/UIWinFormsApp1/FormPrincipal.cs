using POO;

namespace UIWinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        Carro meuCarro;
        public FormPrincipal()
        {
            InitializeComponent();
            meuCarro = new Carro("Honda", "Civic", "Preto", 2023, "CPR2250", 50, 100, 240);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Exibir();
        }
        private void ExibirPneu(Pneu _pneu, TextBox _textBox)
        {
            _textBox.Text = "Aro: " + _pneu.Aro;
            _textBox.Text = _textBox.Text + "\r\nMarca: " + _pneu.Marca;
            _textBox.Text = _textBox.Text + "\r\nPSI: " + _pneu.PSI;
            _textBox.Text = _textBox.Text + "\r\nPsiMaximo: " + _pneu.PSIMaximo;
            _textBox.Text = _textBox.Text + "\r\nPsiMinimo: " + _pneu.PSIMinimo;
            _textBox.Text = _textBox.Text + "\r\nLargura: " + _pneu.Largura;
            _textBox.Text = _textBox.Text + "\r\nPercentualDeBorracha: " + _pneu.PercentualDeBorracha;
            _textBox.Text = _textBox.Text + "\r\nVelocidadeMaxima: " + _pneu.VelocidadeMaxima;
            _textBox.Text = _textBox.Text + "\r\nVelocidadeAtual:" + _pneu.VelocidadeAtual;
            _textBox.Text = _textBox.Text + "\r\nCargaAtual: " + _pneu.CargaAtual;
            _textBox.Text = _textBox.Text + "\r\nCargaMaxima: " + _pneu.CargaMaxima;
            _textBox.Text = _textBox.Text + "\r\nEstourado: " + _pneu.Estourado;
            _textBox.Text = _textBox.Text + "\r\nFurado: " + _pneu.Furado;
            _textBox.Text = _textBox.Text + "\r\nEstepe: " + _pneu.Estepe;

            _textBox.BackColor = Color.White;

            if (_pneu.Estourado)
                _textBox.BackColor = Color.Red;

        }
        private void Exibir()
        {
            textBoxExibir.Text = "\r\nMarca: " + meuCarro.Marca;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nModelo: " + meuCarro.Modelo;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCor: " + meuCarro.Cor;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nAno: " + meuCarro.Ano;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPlaca: " + meuCarro.Placa;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCapacidade Do Tanque: " + meuCarro.CapacidadeDoTanque;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPercentual De Combustível : " + meuCarro.PercentualDeCombustivel + "%";
            textBoxExibir.Text = textBoxExibir.Text + "\r\nLigado: " + meuCarro.Ligado;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nVelocidade Atual: " + meuCarro.VelocidadeAtual;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nVelocidade Máxima: " + meuCarro.VelocidadeMaxima;

            ExibirPneu(meuCarro.PneuDianteiroEsquerdo, textBoxPneuDianteiroEsquerdo);
            ExibirPneu(meuCarro.PneuDianteiroDireito, textBoxPneuDianteiroDireito);
            ExibirPneu(meuCarro.PneuTraseiroEsquerdo, textBoxPneuTraseiroEsquerdo);
            ExibirPneu(meuCarro.PneuTraseiroDireito, textBoxPneuTraseiroDireito);
            ExibirPneu(meuCarro.PneuDeEstepe, textBoxPneuDeEstepe);

            if (meuCarro.Ligado)
                buttonLigar.Text = "Desligar";
            else
                buttonLigar.Text = "Ligar";
        }

        private void textBoxEstepe_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (meuCarro.Ligado)
                meuCarro.Desligar();
            else
                meuCarro.Ligar();

            Exibir();
        }
        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            meuCarro.Acelerar(Convert.ToInt32(textBoxImpulso.Text));
            Exibir();
        }

        private void buttonFrear_Click(object sender, EventArgs e)
        {
            meuCarro.Frear(Convert.ToInt32(textBoxImpulso.Text));
            Exibir();

        }
        private void buttonTrocarPneu_Click(object sender, EventArgs e)
        {
            try
            {
                Pneu pneu = null;
                switch (comboBoxPneu.SelectedIndex)
                {
                    case 0:
                        pneu = meuCarro.PneuDianteiroEsquerdo;
                        meuCarro.PneuDianteiroEsquerdo = meuCarro.PneuDeEstepe;
                        break;
                    case 1:
                        pneu = meuCarro.PneuDianteiroDireito;
                        meuCarro.PneuDianteiroDireito = meuCarro.PneuDeEstepe;
                        break;
                    case 2:
                        pneu = meuCarro.PneuTraseiroEsquerdo;
                        meuCarro.PneuTraseiroEsquerdo = meuCarro.PneuDeEstepe;
                        break;
                    case 3:
                        pneu = meuCarro.PneuTraseiroDireito;
                        meuCarro.PneuTraseiroDireito = meuCarro.PneuDeEstepe;
                        break;
                }
                if (pneu != null)
                    meuCarro.PneuDeEstepe = pneu;

                Exibir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}