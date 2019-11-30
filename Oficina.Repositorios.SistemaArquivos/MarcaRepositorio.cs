using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class MarcaRepositorio
    {
        private string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoMarca"];

        public List<Marca> GetMarca()
        {
            var marcas = new List<Marca>();
            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                if (string.IsNullOrEmpty(linha)) { continue; }

                var propiedades = linha.Split('|');


                var marca = new Marca();


                marca.Id = Convert.ToInt32(propiedades[0]);
                marca.Nome = propiedades[1];
                marcas.Add(marca);
            }

            return marcas;
        }

        public Marca GetMarca(int id)
        {
            Marca marca = null;

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }
                var propiedades = linha.Split('|');
                var linhaId = Convert.ToInt32(propiedades[0]);
                if (id == linhaId)
                {
                    marca = new Marca();

                    marca.Id = linhaId;
                    marca.Nome = propiedades[1];
                    break;
                }

            }
            return marca;
        }
    }
}
