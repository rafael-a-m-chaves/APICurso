using APICurso.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APICurso.Infra.Mapping
{
    public class ClienteMap
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(r => r.Codigo);
            builder.Property(r => r.Nome);
            builder.Property(r => r.LimiteCredito);
            builder.Property(r => r.IsActive);
        }
    }
}
