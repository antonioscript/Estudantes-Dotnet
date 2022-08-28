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


        public async Task<ServiceResponse<List<Estudante>>> AddEstudante(Estudante newEstudante)
        {
            var serviceResponse = new ServiceResponse<List<Estudante>>();
            estudantes.Add(newEstudante);
            
            serviceResponse.Data = estudantes;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Estudante>>> GetAllEstudantes()
        {
            return new ServiceResponse<List<Estudante>> { Data = estudantes };
        }

        public async Task<ServiceResponse<Estudante>> GetEstudanteById(int id)
        {
            var serviceResponse = new ServiceResponse<Estudante>();
            var estudante = estudantes.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = estudante;
            return serviceResponse;
        }
    }
}