using APICurso.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
            builder.Property(r => r.Usuario);
        }
    }
}
