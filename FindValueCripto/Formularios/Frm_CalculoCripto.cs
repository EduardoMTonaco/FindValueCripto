using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindValueCripto.ClassesUtilitarias;

namespace FindValueCripto.Formularios
{
    public partial class Frm_CalculoCripto : Form
    {
        AuxClass auxClass = new AuxClass();
        string GoogleFinanceUrl = "https://www.google.com/finance/quote/";
        string urlEnd;
        public Frm_CalculoCripto(string criptoName)
        {
            InitializeComponent();
            this.Text = $"Calculo do {criptoName}";
            Lbl_Cripto.Text = criptoName;
            Lbl_ValorCripto.Text = "Valor em R$: ";
            Lbl_ValorCalculado.Text = "";
            Mtb_Quantidade.Text = "0000000000";
            Btn_Calcular.Text = "Calcular Quantidade";
            Btn_Sair.Text = "Sair";
            urlEnd = checkCripto(criptoName);
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                Lbl_ValorCalculado.Text = auxClass.CalculaValorQuantidade(Convert.ToDouble(Mtb_Quantidade.Text), GoogleFinanceUrl + urlEnd);
            }
            catch
            {
                MessageBox.Show("Valor incorreto!","Erro valor vazio",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            
        }

        public string checkCripto(string criptoName)
        {
            if(criptoName == "BitCoin")
            {
                return "BTC-BRL";
            }
            if (criptoName == "Ethereum")
            {
                return "ETH-BRL";
            }
            if (criptoName == "Cardano")
            {
                return "ADA-BRL";
            }
            if (criptoName == "XRP")
            {
                return "XRP-BRL";
            }
            throw new Exception("Erro ao identificar CriptoMoeda");
        }

        private void Mtb_Quantidade_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Mtb_Quantidade, "Quantidade de cripto moeda");
        }
    }
}
