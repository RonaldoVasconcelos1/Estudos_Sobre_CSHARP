using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Fundamentos.Capitulo._03.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            var troco = valorPago - valorCompra;

            trocoTextBox.Text = troco.ToString("C");
            //convert arredonda!
            //int moeda1Real = Convert.ToInt32(troco);

            var moedas = new decimal[6] { 1, 0.5m, 0.25m, 0.10m,0.05m, 0.01m };
 
            for (int i = 0; i < moedas.Length ; i++)
            {
                moedaslistView.Items[i].Text = ((int)(troco / moedas[i])).ToString();
                troco %= moedas[i];
            }

            //ToDo: refatorar para usar estrutura de repetição
            // fazemos cast para poder dividir o var. calcula a quantidade de moedas
            //var moeda1Real = (int)(troco / 1);
            //// regula o troco
            //troco %= 1;
            //var moeda50Cent = (int)(troco / 0.5m);
            //troco %= 0.5m;
            //var moeda25Cent = (int)(troco / 0.25m);
            //troco %= 0.25m;
            //var moeda10Cent = (int)(troco / 0.10m);
            //troco %= 0.10m;
            //var moeda5cent = (int)(troco / 0.05m);
            //troco %= 0.05m;
            //var moeda1cent = (int)(troco / 0.01m);
            //troco %= 0.01m;      
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
