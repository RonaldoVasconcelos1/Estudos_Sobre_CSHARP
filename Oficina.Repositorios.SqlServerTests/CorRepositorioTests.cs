using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        private readonly CorRepositorio repositorio = new CorRepositorio();
        [TestMethod()]
        public void LerTest()
        {
            var cores = repositorio.Ler();

            Assert.IsTrue(cores.Count > 0);
            Assert.IsTrue(cores.Any(c => c.Nome == "Branco"));



        }

        [TestMethod()]
        public void lerTest()
        {
            Assert.IsTrue(repositorio.ler(1).Nome == "Preto");
        }

        [TestMethod()]
        public void SalvarTest()
        {
            var IdRosa = repositorio.Salvar(new Cor { Nome = "Rosa" });

            Assert.IsTrue(repositorio.ler(IdRosa).Nome == "Rosa");

        }

        [TestMethod()]
        public void AlterarTest()
        {
            var id = repositorio.Salvar(new Cor { Nome = "Magenta" });

            var cor = repositorio.ler(id);
            cor.Nome = "Magenta Escuro";
            repositorio.Alterar(cor);

            cor = repositorio.ler(id);

            Assert.IsTrue(cor.Nome == "Magenta Escuro");
        }

        [TestMethod()]
        public void ApagarTest()
        {
            repositorio.Apagar(5);

            Assert.IsNull(repositorio.ler(5));
        }
    }
}
