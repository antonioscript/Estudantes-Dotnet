using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudantes_Dotnet.Dtos.Estudante;

namespace Estudantes_Dotnet.Services.EstudanteService
{
    public interface IEstudanteService
    {
        //GET - Pegar todos os Estudantes
        Task<ServiceResponse<List<GetEstudanteDto>>> GetAllEstudantes();

        //GET - Pegar o Estudante por Id específico
        Task<ServiceResponse<GetEstudanteDto>> GetEstudanteById(int id);

        //POST - Adicionar Estudante
        Task<ServiceResponse<List<GetEstudanteDto>>> AddEstudante(AddEstudanteDto newEstudante);

        //PUT - Atualizar Estudante
        Task<ServiceResponse<GetEstudanteDto>> UpdateEstudante(UpdateEstudanteDto updateEstudante);
    }
}