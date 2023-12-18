using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public string Medida { get; set; }

        public Produto(int id_produto = 0, string descricao_produto = "", decimal valor = 0, string tipo = "",
            string medida_unitaria = "")
        {
            Id = id_produto;
            Descricao = descricao_produto;
            Valor = valor;
            Tipo = tipo;
            Medida = medida_unitaria;
        }

        public override string ToString()
        {
            return Descricao;
        }
    }

}
