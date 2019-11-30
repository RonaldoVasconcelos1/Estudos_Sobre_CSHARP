using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImpactaCSarpFundamentos.Capitulo05.Repeticao.Testes
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void TabuadaTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('-', 50));
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i } X {j} = { i * j}");

                }
                Console.WriteLine(new string('-', 50));
            }

        }
        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;
            for (Console.WriteLine("INICIOU"); i <= 3; Console.WriteLine(i))
            {
                i++;
            }
        }
        /* for(1.Inicialização;2. Condição;4. Pós Execução)
         * 3. Execução
         */
        [TestMethod]
        public void ForApenasComCondicaoTeste()
        {
            var i = 1;
            for (; i <=3;)
            {
                Console.WriteLine(i++);

            }
        }
        [TestMethod]
        public void ContinueTeste()
        {
            for (int i= 0; i <+10 ; i++)
            {
                if (i <=5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        public void BreakTeste()
        {
            for (int i = 0; i < +10; i++)
            {
                if (i >5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

    }
}
