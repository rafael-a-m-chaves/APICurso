using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICurso.Domain.Entities
{
    public class Log
    {
        //Classe para guardar quaisquer alterações nos valores das tabelas do sitema
        public int Id { get; set; }
        public string Observacao { get; set; }
        public string NomeEntidade { get; set; }
        public int IdEntitade { get; set; }
    }
}
