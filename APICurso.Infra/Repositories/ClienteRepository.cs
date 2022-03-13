using APICurso.Domain.Entities;
using APICurso.Infra.Contexts;
using APICurso.Infra.IRepositories;

namespace APICurso.Infra.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        Context context;
        public ClienteRepository(Context ctx) : base(ctx)
        {
            context = ctx;
        }
    }
}
