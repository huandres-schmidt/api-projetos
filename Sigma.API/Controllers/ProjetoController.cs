using Microsoft.AspNetCore.Mvc;
using Sigma.Application.Dtos;
using Sigma.Application.Interfaces;
using Sigma.Domain.Dtos;

namespace Sigma.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoService _projetoService;

        public ProjetoController(IProjetoService projetoService)
        {
            _projetoService = projetoService;
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<IActionResult> Inserir([FromBody] ProjetoNovoDto model)
        {
            return new JsonResult(await _projetoService.Inserir(model));
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAll() 
        {
            var projetos = await _projetoService.GetAll();
            return Ok(projetos);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] ProjetoDto model) 
        {
            return new JsonResult(await _projetoService.Add(model));
        }
    }
}
