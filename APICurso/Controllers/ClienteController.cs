using APICurso.Application.IServices;
using APICurso.Domain.DTO;
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
    public class ClienteController : ControllerBase
    {
        //Construindo os Serviços que serão nescessarios para controller
        private readonly IClienteService clienteService;
        public ClienteController(IClienteService service)
        {
            clienteService = service;
        }

        //metodo para listar todos os clientes
        [HttpGet]
        [Route("ListarClientes")]
        public ActionResult ListarCliente()
        {
            try //bloco para proteçao
            {
                var clienteList = clienteService.Get(r => r.IsActive != false);
                List<ListarClientes> model = clienteList.Select(r => new ListarClientes
                {
                    Nome = r.Nome,
                    Codigo = r.Codigo
                }).ToList();
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
