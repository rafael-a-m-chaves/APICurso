using APICurso.Application.IServices;
using APICurso.Domain.Entities;
using APICurso.Infra.IRepositories;

namespace APICurso.Application.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository repository;
        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            repository = clienteRepository;
        }
    }
}
