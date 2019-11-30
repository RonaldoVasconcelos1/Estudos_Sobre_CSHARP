using System.Configuration;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class RepositorioBase
    {
        public string CaminhoArquivo { get; set; }

        public RepositorioBase(string caminho )
        {
            CaminhoArquivo = ConfigurationManager
                .AppSettings[caminho];
        }
    }
}