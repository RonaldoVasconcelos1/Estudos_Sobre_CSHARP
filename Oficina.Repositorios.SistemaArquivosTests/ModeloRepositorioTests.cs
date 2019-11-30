using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        [TestMethod()]
        public void GetModeloTest()
        {
            var modelos = modeloRepositorio.GetModeloPorMarca(4);
            foreach (var modelo in modelos)
            {
                Console.WriteLine($"{modelo.Id} - {modelo.Nome} - { modelo.Marca.Nome}");
            }
        }


        [TestMethod()]
        public void GetModeloTest1()
        {
            var modeloRepositorio = new ModeloRepositorio();
            var modelo = modeloRepositorio.GetModelo(1);


            Assert.AreEqual(modelo.Nome, "Argo");
            Console.WriteLine($"Modelo Selecionada: {modelo.Nome}");

        }
    }
}
