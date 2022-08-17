using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindValueCripto.Formularios;
using ValueCriptoExtractor;

namespace FindValueCripto.ClassesUtilitarias
{
    public class AuxClass
    {
        IRegexExtrator regex = new RegexExtrator("s*[-+]?([0-9]{0,3}(,[0-9]{3})*(\\.[0-9]+)?)", "<div class=\"YMlKec fxKbKc\">", "</div>");
        public string GetDate()
        {
            return $"{DateTime.Now}";
        }
        public string GetFonte()
        {
            return $"Informações retiradas do site: https://www.google.com/finance/";
        }
        public double GetCriptoValue(string url)
        {
            try
            {
                var SharePriceBitcoin = new GetSharePrice(regex, url);
                return SharePriceBitcoin.FindValue(Format.PT);
            }
            catch
            {
                MessageBox.Show("Não foi possivel conectar com o site, verifique a internet.", "Erro na conexão.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        public void ShowFrm_CalculoCripto(string criptoName)
        {
            var formulario = new Frm_CalculoCripto(criptoName);
            formulario.ShowDialog();
        }
        public string CalculaValorQuantidade(double quantidade, string url)
        {
            double amount = Convert.ToDouble(quantidade);
            amount = amount * GetCriptoValue(url);
            return amount.ToString();
        }
    }
}
