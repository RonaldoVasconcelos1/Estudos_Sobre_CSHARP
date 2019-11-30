using Oficina.Repositorios.SistemaArquivos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        CorRepositorio corRepositorio = new CorRepositorio();
        [TestMethod()]
        public void GetCorTest()
        {

            var cores = corRepositorio.GetCor();

            foreach (var cor in cores)
            {
                Console.WriteLine($"{cor.Id} - {cor.Nome}");
            }
        }

        [TestMethod()]
        public void GetCorTest1()
        {

            var cor = corRepositorio.GetCor(3);
            Assert.AreEqual(cor.Nome, "Branco");
            Console.WriteLine($"Cor Selecionada:{cor.Nome}");

        }
    }
}