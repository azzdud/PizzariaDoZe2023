using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class ProdutoDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public ProdutoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void Inserir(Produto produto)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
                                           // NOME
            var descricao_produto = comando.CreateParameter();
            descricao_produto.ParameterName = "@descricao_produto";
            descricao_produto.Value = produto.Descricao;
            comando.Parameters.Add(descricao_produto);

            var valor = comando.CreateParameter();
            valor.ParameterName = "@valor";
            valor.Value = produto.Valor;
            comando.Parameters.Add(valor);

            var tipo = comando.CreateParameter();
            tipo.ParameterName = "@tipo";
            tipo.Value = produto.Tipo;
            comando.Parameters.Add(tipo);

            var medida_unitaria = comando.CreateParameter();
            medida_unitaria.ParameterName = "@medida_unitaria";
            medida_unitaria.Value = produto.Medida;
            comando.Parameters.Add(medida_unitaria);

            // Abre a conexão
            conexao.Open();

            // Define o comando SQL
            comando.CommandText = @"
            INSERT INTO cad_produtos(descricao_produto, valor, tipo, medida_unitaria)
            VALUES (@descricao_produto, @valor, @tipo, @medida_unitaria)";

            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public DataTable Buscar(Produto produto)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (produto.Id > 0)
            {
                auxSqlFiltro = "WHERE i.id_produto = " + produto.Id + " ";
            }
            else if (produto.Descricao.Length > 0)
            {
                auxSqlFiltro = "WHERE i.descricao_produto like '%" + produto.Descricao + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.id_produto AS ID, i.descricao_produto AS Descricao " +
            "FROM tb_produtos AS i " +
            auxSqlFiltro +
            "ORDER BY i.descricao_produto;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }

}
