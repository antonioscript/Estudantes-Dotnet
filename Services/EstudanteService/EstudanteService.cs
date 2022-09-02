using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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

        private readonly IMapper _mapper;
        public EstudanteService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetEstudanteDto>>> AddEstudante(AddEstudanteDto newEstudante)
        {
            var serviceResponse = new ServiceResponse<List<GetEstudanteDto>>();
            Estudante estudante = _mapper.Map<Estudante>(newEstudante);
            estudante.Id = estudantes.Max(c => c.Id) + 1;
            estudantes.Add(estudante);
            serviceResponse.Data = estudantes.Select(c => _mapper.Map<GetEstudanteDto>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetEstudanteDto>>> GetAllEstudantes()
        {
            return new ServiceResponse<List<GetEstudanteDto>> 
            { 
                Data = estudantes.Select(c => _mapper.Map<GetEstudanteDto>(c)).ToList() 
            };
        }

        public async Task<ServiceResponse<GetEstudanteDto>> GetEstudanteById(int id)
        {
            var serviceResponse = new ServiceResponse<GetEstudanteDto>();
            var estudante = estudantes.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetEstudanteDto>(estudante);
            return serviceResponse;
        }
    }
}