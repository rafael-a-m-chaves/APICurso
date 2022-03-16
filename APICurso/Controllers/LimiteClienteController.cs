using APICurso.Application.IServices;
using APICurso.Domain.DTO;
using APICurso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICurso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LimiteClienteController : ControllerBase
    {
        //Construindo os Serviços que serão nescessarios para controller
        private readonly ILimiteClienteService clienteService;
        public LimiteClienteController(ILimiteClienteService service)
        {
            clienteService = service;
        }

        //metodo para listar todos os clientes
        [HttpGet]
        [Route("ListarClientes")]
        public IActionResult ListarCliente(string usuario)
        {
            try //bloco para proteçao
            {
                List<LimiteCliente> clienteList = new List<LimiteCliente>();
                if (usuario.Contains("Administrador")) //Verifica se é administrador, pois somente o administrador pode ver todos clientes
                {
                    clienteList = clienteService.Get().ToList();
                }
                else
                {
                    //Seleciona somente os Clientes ativos
                    clienteList = clienteService.Get(r => r.IsActive != false).ToList();
                }

                List<RetornaListarClientes> model = clienteList.Select(r => new RetornaListarClientes
                {
                    Nome = r.Nome,
                    Codigo = r.Codigo,
                    IsActive = r.IsActive
                    
                }).ToList();
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("CadastrarCliente")]
        public IActionResult CadastrarNovoCliente([FromBody] RecebeCadastrarCliente model)
        {
            try
            {
                //Verifica se quem quer Cadastrar Tem altorizaçãoo
                if (model.Usuario.Contains("Administrador") || model.Usuario.Contains("Financeiro"))
                {
                    clienteService.SalvarNovoCliente(model);
                    return Ok(); //retorna 200 confirmando que ação pode ser concluida
                }
                else
                {
                    //retorna status 401 de nao tem autorização
                    return Unauthorized();
                }

            }
            catch (Exception ex)
            {
                // retorna 400 de requisição nao pode ser executada
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("AlterarLimiteCliente")]
        public IActionResult AlterarLimiteCliente([FromBody] RecebeClienteAlterarValor model)
        {
            try
            {
                //verifica o tipo de operação
                if (model.Subtrair)
                {
                    clienteService.AlterarLimiteCliente(model);
                    return Ok();
                }
                else
                {
                    //somente o administrador e o financeiro tem autorizaçao para aomentar o limite
                    if (model.Usuario.Contains("Administrador") || model.Usuario.Contains("Financeiro"))
                    {
                        clienteService.AlterarLimiteCliente(model);
                        return Ok();
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("AlterarNomeCliente")]
        public IActionResult AlterarNomeCliente([FromBody] RecebeClienteAlterarNome model)
        {
            //somente o administrador tem autorização para alterarnome
            try
            {
                if (model.Usuario.Contains("Administrador"))
                {
                    clienteService.AlterarNomeCliente(model);
                    return Ok();
                }
                else
                {
                    return Unauthorized();
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
 
        }

        [HttpGet]
        [Route("AlterarStatusCliente")]
        public IActionResult AlterarStatusCliente(int codigo, string usuario)
        {
            try
            {
                clienteService.AlterarStatusCliente(codigo,usuario);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("ObterLimiteCliente")]
        public IActionResult ObterLimiteCliente(int id)
        {
            var cliente = clienteService.Find(r => r.Codigo == id);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
