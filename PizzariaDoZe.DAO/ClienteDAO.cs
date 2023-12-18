using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class ClienteDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public ClienteDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void Inserir(Cliente cliente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            // NOME
            var nome = comando.CreateParameter();
            nome.ParameterName = "@nome";
            nome.Value = cliente.Nome;
            comando.Parameters.Add(nome);

            var cpf = comando.CreateParameter();
            cpf.ParameterName = "@cpf";
            cpf.Value = cliente.CPF;
            comando.Parameters.Add(cpf);

            var telefone = comando.CreateParameter();
            telefone.ParameterName = "@telefone";
            telefone.Value = cliente.Telefone;
            comando.Parameters.Add(telefone);

            var email = comando.CreateParameter();
            email.ParameterName = "@email";
            email.Value = cliente.Email;
            comando.Parameters.Add(email);

            var numero = comando.CreateParameter();
            numero.ParameterName = "@numero";
            numero.Value = cliente.Numero;
            comando.Parameters.Add(numero);

            var complemento = comando.CreateParameter();
            complemento.ParameterName = "@complemento";
            complemento.Value = cliente.Complemento;
            comando.Parameters.Add(complemento);

            // Abre a conexão
            conexao.Open();

            // Define o comando SQL
            comando.CommandText = @"
            INSERT INTO tb_clientes(nome_cliente, cpf, telefone, email, numero, complemento)
            VALUES (@nome, @cpf, @telefone, @email, @numero, @complemento)";

            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public DataTable Buscar(Cliente cliente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (cliente.Id > 0)
            {
                auxSqlFiltro = "WHERE i.id_cliente = " + cliente.Id + " ";
            }
            else if (cliente.Nome.Length > 0)
            {
                auxSqlFiltro = "WHERE i.nome_cliente like '%" + cliente.Nome + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.id_cliente AS ID, i.nome_cliente AS Nome, cpf AS CPF, telefone AS Telefone, email AS Email, numero AS Numero, complemento AS Complemento " +
            "FROM tb_clientes AS i " +
            auxSqlFiltro +
            "ORDER BY i.nome_cliente;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}
