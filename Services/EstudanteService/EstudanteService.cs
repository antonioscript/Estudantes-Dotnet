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


        public List<Estudante> AddEstudante(Estudante newEstudante)
        {
            estudantes.Add(newEstudante);
            return estudantes;
        }

        public List<Estudante> GetAllEstudantes()
        {
            return estudantes;
        }

        public Estudante GetEstudanteById(int id)
        {
            return estudantes.FirstOrDefault(c => c.Id == id);
        }
    }
}