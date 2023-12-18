using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CarteiraDeMotorista { get; set; }
        public string Validade { get; set; }
        public string Observacao { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public Funcionario(int id_funcionario = 0, string cpf = "", string matricula = "", string nome_funcionario = "",
            string telefone = "", string email = "", string senha = "", string motorista = "", string validade_motorista = "",
            string observacao = "", string numero = "", string complemento = "")
        {
            Id = id_funcionario;
            CPF = cpf;
            Matricula = matricula;
            Nome = nome_funcionario;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            CarteiraDeMotorista = motorista;
            Validade = validade_motorista;
            Observacao = observacao;
            Numero = numero;
            Complemento = complemento;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
