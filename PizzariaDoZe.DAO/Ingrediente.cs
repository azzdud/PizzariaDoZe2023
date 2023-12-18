using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Ingrediente(int id_ingrediente = 0, string descricao_ingrediente = "")
        {
            Id = id_ingrediente;
            Nome = descricao_ingrediente;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
