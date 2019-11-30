using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Loja.WindowsForms
{
    internal static class Formulario
    {
        internal static bool Validar(Form formulario, ErrorProvider provedorErro)
        {
            var validacao = true;
            var bonifu = formulario.Controls[0];

            foreach (Control controle in bonifu.Controls)
            {
                if (controle.Tag == null)
                {
                    continue;
                }
                if (controle.Tag.ToString().Contains("*") && controle.Text == string.Empty)
                {
                    validacao = DefinirErro(provedorErro, controle, "Campo Obrigatorio.");
                    //deixar o cursor no textbox
                    controle.Focus();
                    validacao = false;
                }
                else
                {
                    validacao = ValidacaoTipoDado(controle, provedorErro);
                }
            }

            return validacao;
        }

        private static bool DefinirErro(ErrorProvider provedorErro, Control controle, string mensagem)
        {
            provedorErro.SetError(controle, mensagem);
            controle.Focus();
            return false;
        }
        private static bool ValidacaoTipoDado(Control controle, ErrorProvider provedorErro)
        {

            var validacao = true;
            var controleTag = controle.Tag.ToString().ToUpper();

            if (controleTag.Contains("PLACA"))
            {
                //IF NOT           //classe REGEX = Regular Expression 
                if (!Regex.IsMatch(controle.Text, @"^[A-Z]{3}[0-9]{4}$"))// string  @"^[A-Z]{3}$", ^Começa com, $ termina com[Tipos de Caracteres]
                {
                    validacao = DefinirErro(provedorErro, controle,
                        "Digite a Placa no Formato AAA-0000");
                }
            }
            else if (controleTag.Contains("ANO"))
            {
                if (Regex.IsMatch(controle.Text, @"\d"))
                {

                    validacao = DefinirErro(provedorErro, controle,
                        "Digite o Ano no AAAA");
                }
            }

            return validacao;
        }
        //internal static void Limpar(Form bonifu)
        //{

        //    foreach (Control controle in bonifu.Controls)
        //    {
        //        if (controle is TextBox || controle is MaskedTextBox)
        //        {
        //            controle.Text = string.Empty;
        //        }
        //        else if(controle is ComboBox)
        //        {
        //            ((ComboBox)controle).SelectedIndex = -1;
        //        }

        //    }
        //}

        public static void Limpar(Control controle)
        {
            foreach (Control obj in controle.Controls)
            {
                if (obj is TextBox ||
                    obj is MaskedTextBox ||
                    obj is ComboBox)
                {
                    obj.ResetText();
                }
                Limpar(obj);
            }
        }
    }
}
