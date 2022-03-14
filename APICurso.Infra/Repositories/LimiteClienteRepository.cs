using APICurso.Domain.Entities;
using APICurso.Infra.Contexts;
using APICurso.Infra.IRepositories;

namespace APICurso.Infra.Repositories
{
    public class LimiteClienteRepository : BaseRepository<LimiteCliente>, ILimiteClienteRepository
    {
        Context context;
        public LimiteClienteRepository(Context ctx) : base(ctx)
        {
            context = ctx;
        }
    }
}
