using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio.Interfaces
{
   public  interface ICorRepositorio
    {
        void Salvar(Cor cor);
        Cor ler(int id);
        List<Cor> Ler();
        void Apagar(int id);
        void Alterar(Cor cor);

    }
}
