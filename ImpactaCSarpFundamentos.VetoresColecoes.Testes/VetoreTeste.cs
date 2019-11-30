//using System;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace ImpactaCSarpFundamentos.VetoresColecoes.Testes
//{
//    [TestClass]
//    public class VetoreTeste
//    {
//        [TestMethod]
//        public void InicializacaoTeste()
//        {
//            var inteiros = new int[5];
//            inteiros[0] = 14;

//            var decimais = new decimal[] { 0.4m, 0.9m, 4, 7.8m };

//            string[] nomes = { "Ronaldo", "Vasconcelos" };

//            foreach (var obj in decimais)
//            {
//                Console.WriteLine(obj);
//            }
//            Console.WriteLine($"O TAMANHO DO VETOR DECIMAIS: {nameof(decimais).Length}");
//        }
//        [TestMethod]
//        //public void RedimensionamentoVetor()
//        //{
//        //    var decimais = new decimal[] {0.5m, 7, 8.9m };

//        //    decimais[4] = 2.3m;
//        //    Array.Resize(ref decimais, 5);

//        //}
//        [TestMethod]
//        public void OrdenarTeste()
//        {
//            var decimais = new decimal[] { 0.5m, 7, 0.9m, -1.4m };

//            Array.Sort(decimais);

//            Assert.AreEqual(decimais[0], -1.4m);
//            //Ordena o vetor 
//        }
//        [TestMethod]
//        public void ParamsTeste()
//        {
//            var decimais = new decimal[] { 0.5m, 7, 0.9m, -1.4m };

//            Console.WriteLine(Media(decimais));
//            Console.WriteLine(Media(1.5m,8,0.5m, 25));
//            Console.WriteLine(decimais.Average());

//        }
//        private decimal Media(decimal nota1, decimal nota2)
//        {
            
//            return (nota1 + nota2) / 2;
//        }

//        private decimal Media(params decimal[] valores)
//        {
//            var soma = 0m;
//            foreach (var obj in valores)
//            {
//               soma += obj;
//            }
//            return soma / valores.Length;
//        }

//        [TestMethod]
//        public void TodaStringEhUmVetorTeste()
//        {
//            var nome = "Ronaldo";
//            Assert.AreEqual(nome[0], 'R');
//            foreach (var item in nome)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}

