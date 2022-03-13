using APICurso.Domain.DTO;
using APICurso.Domain.Entities;

namespace APICurso.Application.IServices
{
    public interface IClienteService : IBaseService<Cliente>
    {
        public void SalvarNovoCliente(RecebeCadastrarCliente recebeCadastrarCliente);
    }
}
