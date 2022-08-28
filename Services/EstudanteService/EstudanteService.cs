using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudantes_Dotnet.Services.EstudanteService
{
    public class EstudanteService : IEstudanteService
    {
        private static List<Estudante> estudantes = new List<Estudante>()
        {
            new Estudante(),
            new Estudante {Id = 1, Nome = "Catarina"}
        };


        public async Task<List<Estudante>> AddEstudante(Estudante newEstudante)
        {
            estudantes.Add(newEstudante);
            return estudantes;
        }

        public async Task<List<Estudante>> GetAllEstudantes()
        {
            return estudantes;
        }

        public async Task<Estudante> GetEstudanteById(int id)
        {
            return estudantes.FirstOrDefault(c => c.Id == id);
        }
    }
}