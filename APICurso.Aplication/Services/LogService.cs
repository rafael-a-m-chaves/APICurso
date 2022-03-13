using APICurso.Application.IServices;
using APICurso.Domain.Entities;
using APICurso.Infra.IRepositories;

namespace APICurso.Application.Services
{
    public class LogService : BaseService<Log>, ILogService
    {
        private readonly ILogRepository repository;
    public LogService(ILogRepository LogRepository) : base(LogRepository)
    {
        repository = LogRepository;
    }
}
}
