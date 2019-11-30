using Oficina.Repositorios.SistemaArquivos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        [TestMethod()]
        public void GetMarcaTest()
        {
            var marcas = marcaRepositorio.GetMarca();
            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.Id} {marca.Nome}");
            }
        }

        [TestMethod()]
        public void GetMarcaTest1()
        {
            var marca = marcaRepositorio.GetMarca(5);


            Assert.AreEqual(marca.Nome, "Toyota");
            Console.WriteLine($"Marca Selecionada: {marca.Nome}");

        }
    }
}