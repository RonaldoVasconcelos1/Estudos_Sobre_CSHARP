﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class Motocicleta : Veiculo
    {
        public TipoQuadro MyProperty { get; set; }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
