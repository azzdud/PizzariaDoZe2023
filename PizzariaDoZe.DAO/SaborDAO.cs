using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class SaborDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public SaborDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void Inserir(Sabor sabor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var descricao_sabor = comando.CreateParameter();
            descricao_sabor.ParameterName = "@descricao_sabor";
            descricao_sabor.Value = sabor.Descricao;
            comando.Parameters.Add(descricao_sabor);

            var foto = comando.CreateParameter();
            foto.ParameterName = "@foto";
            foto.Value = sabor.Foto;
            comando.Parameters.Add(foto);

            var categoria = comando.CreateParameter();
            categoria.ParameterName = "@categoria";
            categoria.Value = sabor.Categoria;
            comando.Parameters.Add(categoria);

            var tipo = comando.CreateParameter();
            tipo.ParameterName = "@tipo";
            tipo.Value = sabor.Tipo;
            comando.Parameters.Add(tipo);

            // Abre a conexão
            conexao.Open();

            // Define o comando SQL
            comando.CommandText = @"
            INSERT INTO tb_sabores(descricao_sabor, foto, categoria, tipo)
            VALUES (@descricao_sabor, @foto, @categoria, @tipo)";

            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public DataTable Buscar(Sabor sabor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (sabor.Id > 0)
            {
                auxSqlFiltro = "WHERE i.id_sabor = " + sabor.Id + " ";
            }
            else if (sabor.Descricao.Length > 0)
            {
                auxSqlFiltro = "WHERE i.descricao_sabor like '%" + sabor.Descricao + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.id_sabor AS ID, i.descricao_sabor AS Descricao " +
            "FROM tb_sabores AS i " +
            auxSqlFiltro +
            "ORDER BY i.descricao_sabor;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}
