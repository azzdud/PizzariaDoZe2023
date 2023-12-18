using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PizzariaDoZe.DAO
{
    public class FuncionarioDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public FuncionarioDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void Inserir(Funcionario funcionario)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)

            var nome_funcionario = comando.CreateParameter();
            nome_funcionario.ParameterName = "@nome_funcionario";
            nome_funcionario.Value = funcionario.Nome;
            comando.Parameters.Add(nome_funcionario);

            var cpf = comando.CreateParameter();
            cpf.ParameterName = "@cpf";
            cpf.Value = funcionario.CPF;
            comando.Parameters.Add(cpf);

            var matricula = comando.CreateParameter();
            matricula.ParameterName = "@matricula";
            matricula.Value = funcionario.Matricula;
            comando.Parameters.Add(matricula);

            var senha = comando.CreateParameter();
            senha.ParameterName = "@senha";
            senha.Value = funcionario.Senha;
            comando.Parameters.Add(senha);

            var motorista = comando.CreateParameter();
            motorista.ParameterName = "@motorista";
            motorista.Value = funcionario.CarteiraDeMotorista;
            comando.Parameters.Add(motorista);

            var validade_motorista = comando.CreateParameter();
            validade_motorista.ParameterName = "@validade_motorista";
            validade_motorista.Value = funcionario.Validade;
            comando.Parameters.Add(validade_motorista);

            var observacao = comando.CreateParameter();
            observacao.ParameterName = "@observacao";
            observacao.Value = funcionario.Observacao;
            comando.Parameters.Add(observacao);

            var telefone = comando.CreateParameter();
            telefone.ParameterName = "@telefone";
            telefone.Value = funcionario.Telefone;
            comando.Parameters.Add(telefone);

            var email = comando.CreateParameter();
            email.ParameterName = "@email";
            email.Value = funcionario.Email;
            comando.Parameters.Add(email);

            var numero = comando.CreateParameter();
            numero.ParameterName = "@numero";
            numero.Value = funcionario.Numero;
            comando.Parameters.Add(numero);

            var complemento = comando.CreateParameter();
            complemento.ParameterName = "@complemento";
            complemento.Value = funcionario.Complemento;
            comando.Parameters.Add(complemento);

            // Abre a conexão
            conexao.Open();

            // Define o comando SQL
            comando.CommandText = @"
            INSERT INTO tb_funcionarios(nome_funcionario, cpf, matricula, senha, motorista, validade_motorista, observacao, telefone, email, numero, complemento)
            VALUES (@nome_funcionario, @cpf, @matricula, @senha, @motorista, @validade_motorista, @observacao, @telefone, @email, @numero, @complemento)";

            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public DataTable Buscar(Funcionario funcionario)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (funcionario.Id > 0)
            {
                auxSqlFiltro = "WHERE i.id_funcionario = " + funcionario.Id + " ";
            }
            else if (funcionario.Nome.Length > 0)
            {
                auxSqlFiltro = "WHERE i.nome_funcionario like '%" + funcionario.Nome + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.id_funcionario AS ID, i.nome_funcionario AS Nome, i.cpf AS CPF, i.matricula AS Matricula, i.senha AS Senha, i.motorista AS CarteiraDeMotorista, i.validade_motorista AS Validade, i.observacao AS Observacao, i.telefone AS Telefone, i.email AS Email, i.numero AS Numero, i.complemento AS Complemento " +
            "FROM tb_funcionarios AS i " +
            auxSqlFiltro +
            "ORDER BY i.nome_funcionario;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}
