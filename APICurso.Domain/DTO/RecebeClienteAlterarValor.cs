using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICurso.Domain.DTO
{
    public class RecebeClienteAlterarValor
    {
        public string Usuario { get; set; }
        public int Codigo { get; set; }
        public double Valor { get; set; }
        public bool Subtrair { get; set; }

    }
}
