using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudantes_Dotnet.Services.EstudanteService;
using Microsoft.AspNetCore.Mvc;

namespace Estudantes_Dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudanteController : ControllerBase
    {
        private readonly IEstudanteService _estudanteService;

        public EstudanteController(IEstudanteService estudanteService)
        {
            _estudanteService = estudanteService;
        }


        //Pegar Todos os estudantes
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Estudante>>>> Get()
        {
            return Ok(await _estudanteService.GetAllEstudantes());
        }

        //Pegar Por Id Específico
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Estudante>>>> GetSingle(int id)
        {
            return Ok(await _estudanteService.GetEstudanteById(id));
        }

        //Método Post
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Estudante>>>> AddEstudante(Estudante newEstudante)
        {
            return Ok(await _estudanteService.AddEstudante(newEstudante));
        }
    }
}