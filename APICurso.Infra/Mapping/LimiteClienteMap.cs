using APICurso.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APICurso.Infra.Mapping
{
    public class LimiteClienteMap
    {
        public void Configure(EntityTypeBuilder<LimiteCliente> builder)
        {
            builder.HasKey(r => r.Codigo);
            builder.Property(r => r.Nome);
            builder.Property(r => r.LimiteCredito);
            builder.Property(r => r.IsActive);
        }
    }
}
