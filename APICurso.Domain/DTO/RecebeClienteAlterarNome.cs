﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICurso.Domain.DTO
{
    public class RecebeClienteAlterarNome
    {
        public string Usuario { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
}
