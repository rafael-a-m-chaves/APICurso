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
        //parte para criar regras de negocio especificas para cada entidade
        public void SalvarNovoLog(int idEntitade, string nomeEntidade, string observacao, string usuario)
        {
            //este metodo criar um novo registro de log

            Log log = new Log();
            log.IdEntitade = idEntitade;
            log.NomeEntidade = nomeEntidade;
            log.Observacao = observacao;
            log.Usuario = usuario;
            
            repository.Save(log); //persiste o novo log

        }
    }
}
