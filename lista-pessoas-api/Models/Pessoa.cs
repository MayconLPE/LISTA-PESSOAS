using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lista_pessoas_api.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}