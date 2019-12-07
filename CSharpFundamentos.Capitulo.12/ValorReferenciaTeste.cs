using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using System.Text;

namespace CSharpFundamentos.Capitulo._12
{
    [TestClass]
    public class ValorReferenciaTeste
    {
        [TestMethod]
        public void PassagemValorTeste()
        {
            var x = 1;
            Transformar(x);

            Assert.IsTrue(x == 1);
        }


        [TestMethod]
        public void PassagemPorReferenciaTeste()
        {
            var cor = new Cor();

            cor.Nome = "Preto";
            cor.Id = 1;
            Transformar(cor);
            Assert.AreEqual(cor.Nome, "Branco");
        }

        [TestMethod]
        public void PassagemPorValorUsandoReferenciaTeste()
        {
            var x = 1;
            Transformar(ref x);
            Assert.IsTrue(x == 2);
        }

        [TestMethod]
        public void StringSaoImutaveisTeste()
        {
            var texto = "aaa";
            string.Concat(texto, "a");
            texto.Replace("a", "b");

            Assert.IsTrue(texto == "aaa");

            texto = string.Concat(texto, "b");
            texto = texto.Replace("a", "b");
            Assert.AreEqual(texto, "bbbb");

            var mutavel = new StringBuilder("aaa");
            mutavel.Append("a");
            mutavel.Replace("a", "b");
            Assert.IsTrue(mutavel.ToString() == "bbbb");

        }
        [TestMethod]
        public void StructTeste()
        {
            var estrutura = new Estrutura();
            estrutura.Id = 1;

            Transformar(estrutura);

            Assert.IsTrue(estrutura.Id == 1);
        }

        [TestMethod]
        public void StrucVsClassTeste()
        {
            var x = 42;
            Assert.IsTrue(x.GetType().IsValueType);

            var y = new int();
            y = 10;
            Assert.IsTrue(y.GetType().IsValueType);

            var meuObjeto = new object();
            Assert.IsTrue(meuObjeto.GetType().IsClass);

            var nome = "Ronaldo";
            Assert.IsTrue(nome.GetType().IsClass);
            
        }

        private void Transformar(Estrutura estrutura)
        {
            estrutura.Id = 5;
        }

        private struct Estrutura
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
        private void Transformar(int x)
        {
            //x = x + 1;
            //x += 1;
            x++;
            //++x;
        }
        private void Transformar(ref int x)
        {
            //x = x + 1;
            //x += 1;
            x++;
            //++x;
        }
        public void Transformar(Cor cor)
        {
            cor.Nome = "Branco";
        }

    }
}
