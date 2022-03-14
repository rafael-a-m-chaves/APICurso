using APICurso.Application.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICurso.Controllers
{
    public class LogController : Controller
    {
        private readonly ILogService logService;
        public LogController(ILogService _logService)
        {
            logService = _logService;
        }

        [HttpGet]
        [Route("ListarHistorico")]
        public IActionResult ListarHistorico(int codigo, string nomeEntidade)
        {
            try
            {
                var log = logService.Get(r => r.IdEntitade == codigo && r.NomeEntidade == nomeEntidade).ToList().OrderBy(x => x.Id);
                return Ok(log);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
