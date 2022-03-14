using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICurso.Domain.DTO
{
    public class RecebeCadastrarCliente
    {
        public string Nome { get; set; }
        public decimal Limite { get; set; }
        public int Codigo { get; set; }
        public string Usuario { get; set; }

    }
}
