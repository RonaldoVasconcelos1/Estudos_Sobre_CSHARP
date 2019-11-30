using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ImpactaCSarpFundamentos.VetoresColecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>() {1,8,3,16,-78 };
            inteiros.Add(27);
            inteiros.Add(-8);

            var maisInteiros = new List<int>() { 16, 38, -8 };

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0, 50);//insere um elemento passado com o parametro o index e o conteudo

            inteiros.Remove(50);// remore apenas a primeira ocorrencia

            inteiros.RemoveAll(i => i == 16);//expressao lambda

            inteiros.RemoveAt(1);

            inteiros.Sort();
            var primeiro = inteiros.First();
            var ultimo = inteiros[inteiros.Count-1];

            foreach (var obj in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(obj)}: {obj}");
            }

        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2019/11/15), "Proclamação da Republica");
            feriados.Add(Convert.ToDateTime("20/11/2019"), "Consiência Negra");
            feriados.Add(Convert.ToDateTime("25/01/2019"), "Niver de SP");

            //feriados.Add(new DateTime(2019 / 11 / 15), "Proclamação da Republica"); a chave tem que ser unica


            var proclamacao = feriados[new DateTime(2019 / 11 / 15)];

            foreach(var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToShortDateString()} :{feriado.Value}" );
            }
            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("20/11/2019")));
            Console.WriteLine(feriados.ContainsValue("Proclamação da Republica"));
        }

    }
}
