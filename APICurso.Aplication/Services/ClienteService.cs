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

            try
            {
                string nomeEntidade = "Cliente";
                string observacao = "Foi Criado um novo Cliente";
                logService.SalvarNovoLog(cliente.Codigo, nomeEntidade, observacao, recebeCadastrarCliente.Usuario);
            }
            catch
            {
                //Caso não consiga criar o log exclui o cliente
                repository.Delete(cliente);
                throw;
            }
            
        }
        
    }
}
