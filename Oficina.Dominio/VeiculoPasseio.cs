using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //ToDo: OO -Herança(:)
    public class VeiculoPasseio : Veiculo
    {
        public Carroceria Carroceria { get; set; }

        //ToDo: OO -polimorfismo por sobrescrita(OVERRIDE)
        public override List<string> Validar()
        {
            var erros = ValidarBase();
            if (!Enum.IsDefined(typeof(Carroceria), Carroceria))
            {
                erros.Add($"A Carroceria Informada{Carroceria} Não é Valida");
            }

            return erros;

        }
    }

}
