using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudantes_Dotnet.Dtos.Estudante;

namespace Estudantes_Dotnet.Services.EstudanteService
{
    public class EstudanteService : IEstudanteService
    {
        private static List<Estudante> estudantes = new List<Estudante>()
        {
            new Estudante(),
            new Estudante {Id = 1, Nome = "Catarina"}
        };


        public async Task<ServiceResponse<List<GetEstudanteDto>>> AddEstudante(AddEstudanteDto newEstudante)
        {
            var serviceResponse = new ServiceResponse<List<GetEstudanteDto>>();
            estudantes.Add(newEstudante);
            
            serviceResponse.Data = estudantes;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetEstudanteDto>>> GetAllEstudantes()
        {
            return new ServiceResponse<List<GetEstudanteDto>> { Data = estudantes };
        }

        public async Task<ServiceResponse<GetEstudanteDto>> GetEstudanteById(int id)
        {
            var serviceResponse = new ServiceResponse<GetEstudanteDto>();
            var estudante = estudantes.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = estudante;
            return serviceResponse;
        }
    }
}