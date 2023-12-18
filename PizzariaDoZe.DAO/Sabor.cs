using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Sabor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public Sabor(int id_sabor = 0, string descricao_sabor = "", string foto = "", 
            string categoria = "", string tipo = "")
        {
            Id = id_sabor;
            Descricao = descricao_sabor;
            Foto = foto;
            Categoria = categoria;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
