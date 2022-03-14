using APICurso.Domain.DTO;
using APICurso.Domain.Entities;

namespace APICurso.Application.IServices
{
    public interface ILimiteClienteService : IBaseService<LimiteCliente>
    {
        public void SalvarNovoCliente(RecebeCadastrarCliente recebeCadastrarCliente);

        public void AlterarLimiteCliente(RecebeClienteAlterarValor recebeClienteAlterarValor);

        public void AlterarNomeCliente(RecebeClienteAlterarNome recebeClienteAlterarNome);
        public void AlterarStatusCliente(int codigo, string usuario);
    }
}
