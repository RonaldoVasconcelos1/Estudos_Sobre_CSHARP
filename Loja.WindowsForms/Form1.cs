using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Windows.Forms;

namespace Loja.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopularControles();
        }
        private void PopularControles()
        {
            MarcacomboBox.DataSource = new MarcaRepositorio().GetMarca();
            MarcacomboBox.DisplayMember = "Nome";
            MarcacomboBox.ValueMember = "id";
            MarcacomboBox.SelectedIndex = -1;

            CorcomboBox.DataSource = new CorRepositorio().GetCor();
            CorcomboBox.DisplayMember = "Nome";
            CorcomboBox.ValueMember = "id";
            CorcomboBox.SelectedIndex = -1;

            CombustivelcomboBox.DataSource = Enum.GetValues(typeof(Cambio));
            CambiocomboBox.SelectedIndex = -1;

            CombustivelcomboBox.DataSource = Enum.GetValues(typeof(Combustivel));
            CombustivelcomboBox.SelectedIndex = -1;
        }
        private void Gravarbutton_Click(object sender, EventArgs e)
        {
            if (Formulario.Validar(this, VeiculoerrorProvider))
            {
                GravarVeiculo();
            }
        }

        private void GravarVeiculo()
        {
          
        }
    }
}
