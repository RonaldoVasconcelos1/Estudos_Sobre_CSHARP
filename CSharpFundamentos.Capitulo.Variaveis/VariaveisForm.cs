using System.Windows.Forms;
using System;

namespace CSharpFundamentos.Capitulo.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;


        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void VariaveisForm_Load(object sender, System.EventArgs e)
        {

        }

        private void aritiméticasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            resultadoListBox.Items.Clear();
            var a = 2;
            int b = 6;
            var c = 10;
            var d = 13;

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("b = " + b);
            resultadoListBox.Items.Add("c = " + c);
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add($"c*d = {c * d}");
            resultadoListBox.Items.Add($"a/c = {a * c}");
            resultadoListBox.Items.Add($"d % a = {d % a }");
        }

        private void reduzidasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            resultadoListBox.Items.Clear();
            var x = 5;
            resultadoListBox.Items.Add(" x = " + x);

            // expressao reduzida
            x -= 3;
            resultadoListBox.Items.Add("x = " + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            resultadoListBox.Items.Clear();
            int a;

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pré-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + ++a ={2 + ++a} ");
            resultadoListBox.Items.Add("a = " + a);

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pós-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + a++ ={2 + a++} ");
            resultadoListBox.Items.Add("a = " + a);
        }

        private void booleansToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ExibirValores();
            resultadoListBox.Items.Add($"w <= x {w <= x}");
            resultadoListBox.Items.Add($"x == z {x == z}");
            resultadoListBox.Items.Add($"x != z {x != z}");
            resultadoListBox.Items.Add($"w <= x {w <= x}");


        }

        private void ExibirValores()
        {
            resultadoListBox.Items.Add($"x = {x}");
            resultadoListBox.Items.Add($"y = {y}");
            resultadoListBox.Items.Add($"w = {w} ");
            resultadoListBox.Items.Add($"z = {z}");
            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void logicasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            resultadoListBox.Items.Clear();
            ExibirValores();
            resultadoListBox.Items.Add($"w <= x || y == 16 = {w <= x || y == 16}");
            resultadoListBox.Items.Add($"x == z && x != z = {x == z && x != z}");
            resultadoListBox.Items.Add($"(y > w) = {!(y > w)}");

        }

        private void ternariasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int ano;

            ano = 2014;

            resultadoListBox.Items.Add($"O Ano {ano} é bissexto ? {(ano % 4 == 0 ? "Sim" : "Não")}.");


            ano = 2016;

            resultadoListBox.Items.Add($"O Ano {ano} é bissexto ? {(DateTime.IsLeapYear(ano)  ? "Sim" : "Não")}.");


            //var resposta = "";
            //if (ano % 4 == 0)
            //{
            //    resposta = "Sim";

            //}
            //else
            //{
            //    resposta = "Não";

            //}

        }
    }
}
