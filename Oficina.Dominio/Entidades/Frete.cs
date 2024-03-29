﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class Frete
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="valor"></param>
       /// <param name="uf"></param>
        public Frete(decimal valor, UF uf)
        {                                    
            this.Valor = valor;              
            this.UF = uf;
            Calcular();
        }
        public Cliente Cliente { get; set; }
        public decimal Valor { get; private set; }
        public UF UF { get; private set; }
        public decimal Percentual { get; private set; }
        public decimal Total { get; set; }



        private void Calcular()
        {


            switch (UF)
            {
                case UF.SP:
                    Percentual = 0.2m;
                    break;
                case UF.RJ:
                    Percentual = 0.3m;
                    break;
                case UF.MG:
                    Percentual = 0.35m;
                    break;
                case UF.AM:
                    Percentual = 0.6m;
                    break;
                default:
                    Percentual = 0.7m;
                    break;
            }
            Total = ((1 + Percentual) * Valor);
        }
    }
}
