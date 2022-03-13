using APICurso.Domain.Entities;

namespace APICurso.Application.IServices
{
    public interface ILogService : IBaseService<Log>
    {
        public void SalvarNovoLog(int idEntitade, string nomeEntidade, string observacao, string usuario);
    }
}
