using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Fundamentos.Capitulo._04.Frete
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void LimparButtom_Click(object sender, EventArgs e)
        {
            ClientetextBox.Text = string.Empty;
            ValortextBox.Text = string.Empty;
            FretetextBox.Text = string.Empty;
            TotaltextBox.Text = string.Empty;
            UFcomboBox.SelectedIndex = -1;
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();


            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "ERRO DE VALIDAÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Calcular()
        {
            var percentualFrete = 0m;
            var valor = Convert.ToDecimal(ValortextBox.Text);
            switch (UFcomboBox.Text.ToUpper())
            {
                case "SP":
                    {
                        percentualFrete = 0.2m;
                        break;
                    }
                case "RJ":
                    {
                        percentualFrete = 0.3m;
                        break;
                    }
                case "AM":
                    {
                        percentualFrete = 0.6m;
                        break;
                    }
                case "MG":
                    {
                        percentualFrete = 0.35m;
                        break;
                    }
                default:
                    percentualFrete = 0.7m;
                    break;
            }

            FretetextBox.Text = percentualFrete.ToString("P2");
            TotaltextBox.Text = ((1 + percentualFrete) * valor).ToString("C");
        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();

            if (ClientetextBox.Text == string.Empty)
            {
                erros.Add("CAMPO CLIENTE É OBRIGATORIO.");
            }
            if(UFcomboBox.SelectedIndex== -1)
            {
                erros.Add("POR FAVOR SELECIONAR UMA UF.");
            }
            if (ValortextBox.Text == string.Empty)
            {
                erros.Add("DIGITE O VALOR DO PRODUTO.");
            }
            else
            {
                decimal valorConvertido;

                //o exclamação serve para negar a frase
                if (!decimal.TryParse(ValortextBox.Text, out valorConvertido))
                {
                    erros.Add("O CAMPO VALOR DEVE SER NUMERICO");
                }
            }
            return erros;
        }


    }
}
