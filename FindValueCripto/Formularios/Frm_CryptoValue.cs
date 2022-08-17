using FindValueCripto.ClassesUtilitarias;
using FindValueCripto.Formularios;

namespace FindValueCripto
{
    public partial class Frm_CryptoValue : Form
    {
        AuxClass auxClass = new AuxClass();
        string GoogleFinanceUrl = "https://www.google.com/finance/quote/";
        
        string versao = "v1.001";
        public Frm_CryptoValue()
        {
            InitializeComponent();
            Btn_Bitcoin.Text = "Bitcoin";
            Btn_Ethereum.Text = "Ethereum";
            Btn_Cardano.Text = "Cardano";
            Btn_Xrp.Text = "XRP";
            Lbl_Cripto.Text = $"Valor do bitcoin: R${auxClass.GetCriptoValue( GoogleFinanceUrl + "BTC-BRL")}";
            Lbl_Data.Text = auxClass.GetDate();
            Lbl_Fonte.Text = auxClass.GetFonte();
            Lbl_Version.Text = versao;
        }

        private void Btn_Bitcoin_Click(object sender, EventArgs e)
        {
            Lbl_Cripto.Text = $"Valor do bitcoin: R${auxClass.GetCriptoValue( GoogleFinanceUrl + "BTC-BRL")}";
            Lbl_Data.Text = auxClass.GetDate();

        }
        private void Btn_Ethereum_Click(object sender, EventArgs e)
        {
            
            Lbl_Cripto.Text = $"Valor do Ethereum: R${auxClass.GetCriptoValue( GoogleFinanceUrl + "ETH-BRL")}";
            Lbl_Data.Text = auxClass.GetDate();
        }
        private void Btn_Cardano_Click(object sender, EventArgs e)
        {
            Lbl_Cripto.Text = $"Valor do Cardano: R${auxClass.GetCriptoValue( GoogleFinanceUrl + "ADA-BRL")}";
            Lbl_Data.Text = auxClass.GetDate();
        }
        private void Btn_Xrp_Click(object sender, EventArgs e)
        {
            Lbl_Cripto.Text = $"Valor do XRP: R${auxClass.GetCriptoValue(GoogleFinanceUrl + "XRP-BRL")}";
            Lbl_Data.Text = auxClass.GetDate();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bitCoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auxClass.ShowFrm_CalculoCripto("BitCoin");
        }

        private void ethereumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auxClass.ShowFrm_CalculoCripto("Ethereum");
        }

        private void cardanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auxClass.ShowFrm_CalculoCripto("Cardano");
        }

        private void xRPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auxClass.ShowFrm_CalculoCripto("XRP");
        }
    }
}