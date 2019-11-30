using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class ModeloRepositorio : RepositorioBase
    {
        //XDocument é uma classe para manipular Documentos
        private XDocument ArquivoXml;

        public ModeloRepositorio () : base("caminhoArquivoModelo")
        {
            ArquivoXml= XDocument.Load(CaminhoArquivo);
        }

        public List<Modelo> GetModeloPorMarca(int marcaId)
        {
            var modelos = new List<Modelo>();


            foreach (var elemento in ArquivoXml.Descendants("modelo"))
            {
                if (marcaId.ToString() == elemento.Element("marcaId").Value)
                {
                    var modelo = new Modelo();
                    var marcaRep = new MarcaRepositorio();

                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;
                    modelo.Marca = marcaRep.GetMarca(marcaId);
                    modelos.Add(modelo);
                }
            }

            return modelos;
        }
        public Modelo GetModelo(int id)
        {
            Modelo modelos = null;


            foreach (var elemento in ArquivoXml.Descendants("modelo"))
            {
                if(id.ToString() == elemento.Element("id").Value)
                {
                    modelos = new Modelo();
                    modelos.Id = id;
                    modelos.Nome = elemento.Element("nome").Value;

                    var marcaRepositorio = new MarcaRepositorio();

                    modelos.Marca = marcaRepositorio.GetMarca(Convert.ToInt32(elemento.Element("id").Value));
                    break;
                    
                }

            }

            return modelos;
        }

    }
}
