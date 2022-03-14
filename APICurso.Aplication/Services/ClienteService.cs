using APICurso.Application.IServices;
using APICurso.Domain.DTO;
using APICurso.Domain.Entities;
using APICurso.Infra.IRepositories;
using System;

namespace APICurso.Application.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository repository;
        private readonly ILogService logService;
        public ClienteService(IClienteRepository clienteRepository, ILogService _logService) : base(clienteRepository)
        {
            repository = clienteRepository;
            logService = _logService;
        }

        //parte para criar regras de negocio especificas para cada entidade

        public void AlterarLimiteCliente(RecebeClienteAlterarValor recebeClienteAlterarValor)
        {
            Cliente cliente = repository.Find(r => r.Codigo == recebeClienteAlterarValor.Codigo);
            if (cliente == null) throw new Exception("Cliente não encontrado"); // verifica se cliente esta no banco de dados

            cliente.AlterarLimiteDeCredito(recebeClienteAlterarValor.Valor, recebeClienteAlterarValor.Subtrair);
            repository.Save(cliente);
     
            //Criando um registro de log

            string nomeEntidade = "Cliente";
            string observacao;
            //verifica qual operação vai realizar
            if (recebeClienteAlterarValor.Subtrair)
            {
                observacao = "Foi Subtraido R$"+recebeClienteAlterarValor.Valor+" em: " + DateTime.Now.ToString("f(pt-BR)");
            }
            else
            {
                observacao = observacao = "Foi Adicionado R$" + recebeClienteAlterarValor.Valor + " em: " + DateTime.Now.ToString("f(pt-BR)");
            }
             
            logService.SalvarNovoLog(cliente.Codigo, nomeEntidade, observacao, recebeClienteAlterarValor.Usuario);
            
            
        }

        public void AlterarNomeCliente(RecebeClienteAlterarNome recebeClienteAlterarNome)
        {
            Cliente cliente = repository.Find(r => r.Codigo == recebeClienteAlterarNome.Codigo);
            if (cliente == null) throw new Exception("Cliente não encontrado"); // verifica se cliente esta no banco de dados
           
            cliente.AlterarNomeCliente(recebeClienteAlterarNome.Nome);
            repository.Save(cliente);
          

            //Criando um registro de log

            string nomeEntidade = "Cliente";
            string observacao = "Nome do Cliente foi alterado em: " + DateTime.Now.ToString("f(pt-BR)");
            logService.SalvarNovoLog(cliente.Codigo, nomeEntidade, observacao, recebeClienteAlterarNome.Usuario);

        }

        public void AlterarStatusCliente(int codigo, string usuario)
        {
            Cliente cliente = repository.Find(r => r.Codigo == codigo);
            
            if (cliente == null) throw new Exception("Cliente não encontrado"); // verifica se cliente esta no banco de dados
            
            cliente.AlterarStatusCliente();

            repository.Save(cliente);

            //Criando um registro de log

            string nomeEntidade = "Cliente";
            string observacao = "O Cliente Foi inativado em: " + DateTime.Now.ToString("f(pt-BR)");
            logService.SalvarNovoLog(cliente.Codigo, nomeEntidade, observacao, usuario);

        }

        public void SalvarNovoCliente(RecebeCadastrarCliente recebeCadastrarCliente)
        {
            //salvando um novo cliente
            Cliente cliente = new Cliente();
            try
            {
                cliente.CadastrarNovoCliente(recebeCadastrarCliente.Nome, recebeCadastrarCliente.Limite, recebeCadastrarCliente.Codigo);
                repository.Save(cliente);
            }
            catch 
            {
                throw;
            }

            //Criando um registro de log

            string nomeEntidade = "Cliente";
            string observacao = "Foi Criado um novo Cliente em: " + DateTime.Now.ToString("f(pt-BR)");
            logService.SalvarNovoLog(cliente.Codigo, nomeEntidade, observacao, recebeCadastrarCliente.Usuario);

        }
        
    }
}
