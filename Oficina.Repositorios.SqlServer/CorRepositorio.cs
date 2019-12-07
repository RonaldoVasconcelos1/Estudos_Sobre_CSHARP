using Oficina.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using Oficina.Dominio;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Oficina.Repositorios.SqlServer
{
    public class CorRepositorio : ICorRepositorio
    {
        string stringConexao = ConfigurationManager.ConnectionStrings["oficinaSqlServer"].ConnectionString;
        public void Alterar(Cor cor)
        {
            throw new NotImplementedException();
        }

        public void Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cor> Ler()
        {
            var cores = new List<Cor>();

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string instrucao = "Select Id, Nome FROM Cor order by Nome";

                using (var comando = new SqlCommand(instrucao, conexao))
                {
                    using (var registros = comando.ExecuteReader())
                    {
                        while (registros.Read())
                        {
               
                            cores.Add(Mapear(registros));
                        }
                    }
                }
            }
            return cores;
        }

        private Cor Mapear(SqlDataReader registro)
        {
            var cor = new Cor();
            cor.Id = Convert.ToInt32(registro["Id"]);
            //cor.Nome = registro["Nome"].ToString();
            cor.Nome = registro[nameof(cor.Nome)].ToString();

            return cor;
        
        }

        public void Salvar(Cor cor)
        {
            throw new NotImplementedException();
        }

        public Cor ler(int id)
        {
            Cor cor = null;


            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string nomeProcedure = "Corler";

                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;// sempre que tiver trabalhando com proc usar o Stored
                    comando.Parameters.AddWithValue("@Id", id);
                    using (var registros = comando.ExecuteReader())
                    {
                        if (registros.Read())
                        {

                            Mapear(registros);
                        }
                    }
                }
            }
            return cor;
        }
    }
}
