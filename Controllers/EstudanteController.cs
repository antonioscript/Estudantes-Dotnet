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
        public ActionResult<List<Estudante>> Get()
        {
            return Ok(_estudanteService.GetAllEstudantes());
        }

        //Pegar Por Id Específico
        [HttpGet("{id}")]
        public ActionResult<List<Estudante>> GetSingle(int id)
        {
            return Ok(_estudanteService.GetEstudanteById(id));
        }

        //Método Post
        [HttpPost]
        public ActionResult<List<Estudante>> AddEstudante(Estudante newEstudante)
        {
            return Ok(_estudanteService.AddEstudante(newEstudante));
        }
    }
}