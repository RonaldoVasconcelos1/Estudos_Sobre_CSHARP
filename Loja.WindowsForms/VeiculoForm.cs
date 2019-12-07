using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.IO;
using System.Windows.Forms;

namespace Loja.WindowsForms
{
    public partial class VeiculoForm : Form
    {
        //construtor  metodo com o mesmo nome da classe
        // executando automaticamente(new)
        public VeiculoForm()
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

            CombustivelcomboBox.DataSource = Enum.GetValues(typeof(Combustivel));
            CombustivelcomboBox.SelectedIndex = -1;

            CambiocomboBox.DataSource = Enum.GetValues(typeof(Cambio));
            CambiocomboBox.SelectedIndex = -1;
        }
        private void Gravarbutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (Formulario.Validar(this, VeiculoerrorProvider))
                {
                    GravarVeiculo();
                    MessageBox.Show("Veiculo Cadastrado com Sucesso");
                    Formulario.Limpar(this);
                    PlacaTextBox.Focus();
                }

            }
            catch (FileNotFoundException excecao)
            {
                MessageBox.Show($"O arquivo {excecao.FileName} não foi encontrado.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"O Arquivo Veiculo.xml esta com o atributo somente leitura.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("EITAAAA!!! Algo deu errado e estamos trabalhando na solução");
                //logar(ex) log4net
            }

        }
        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (MarcacomboBox.SelectedIndex == -1)
            {
                return;
            }

            var marca = (Marca)MarcacomboBox.SelectedItem;
            ModelocomboBox.DataSource = new ModeloRepositorio().GetModeloPorMarca(marca.Id);
            ModelocomboBox.ValueMember = "Nome";
            ModelocomboBox.ValueMember = "Id";
            ModelocomboBox.SelectedIndex = -1;

        }
        private void GravarVeiculo()
        {
            // atalho para blocos CTRL + K S


            var veiculo = new VeiculoPasseio();

            veiculo.Ano = Convert.ToInt32(AnoTextBox.Text);
            veiculo.Cambio = (Cambio)CambiocomboBox.SelectedItem;
            veiculo.Combustivel = (Combustivel)CombustivelcomboBox.SelectedItem;
            veiculo.Carroceria = Carroceria.Hatch;
            veiculo.Cor = (Cor)CorcomboBox.SelectedItem;
            veiculo.Modelo = (Modelo)ModelocomboBox.SelectedItem;
            veiculo.Observacao = ModelocomboBox.Text;
            veiculo.Placa = PlacaTextBox.Text.ToUpper();

            new VeiculoRepositorio().Inserir(veiculo);


        }

        private void Limparbutton_Click(object sender, EventArgs e)
        {
            Formulario.Limpar(this);

        }
    }
}
