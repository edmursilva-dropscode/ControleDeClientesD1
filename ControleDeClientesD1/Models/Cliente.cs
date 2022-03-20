using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientesD1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Dtnascimento { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Endereco { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Cep { get; set; }
        public String Facebook { get; set; }
        public String Linkedin { get; set; }
        public String Twitter { get; set; }
        public String Instagran { get; set; }

    }
}
