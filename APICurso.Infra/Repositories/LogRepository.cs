using APICurso.Domain.Entities;
using APICurso.Infra.Contexts;
using APICurso.Infra.IRepositories;

namespace APICurso.Infra.Repositories
{
    public class LogRepository : BaseRepository<Log>, ILogRepository
    {
        Context context;
        public LogRepository(Context ctx):base(ctx)
        {
            context = ctx;
        }

    }
}
