using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public Cliente(int id_cliente = 0, string nome_cliente = "", string cpf = "", string telefone = "", 
            string email = "", string numero = "", string complemento = "")
        {
            Id = id_cliente;
            Nome = nome_cliente;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            /// IdEndereco = endereco_id;
            Numero = numero;
            Complemento = complemento;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
