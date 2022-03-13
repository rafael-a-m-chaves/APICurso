using APICurso.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICurso.Infra.Mapping
{
    public class LogMap
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.NomeEntidade);
            builder.Property(r => r.IdEntitade);
            builder.Property(r => r.Observacao);
        }
    }
}
