using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Estudantes_Dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudanteController : ControllerBase
    {
        private static List<Estudante> estudantes = new List<Estudante>()
        {
            new Estudante(),
            new Estudante {Id = 1, Nome = "Catarina"}
        };

        //Pegar Todos os estudantes
        [HttpGet("GetAll")]
        public ActionResult<List<Estudante>> Get()
        {
            return Ok(estudantes);
        }

        [HttpGet]
        public ActionResult<List<Estudante>> GetSingle()
        {
            return Ok(estudantes[0]);
        }
    }
}