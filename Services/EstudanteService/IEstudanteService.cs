using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudantes_Dotnet.Services.EstudanteService
{
    public interface IEstudanteService
    {
        //GET - Pegar todos os Estudantes
        Task<ServiceResponse<List<Estudante>>> GetAllEstudantes();

        //GET - Pegar o Estudante por Id específico
        Task<ServiceResponse<Estudante>> GetEstudanteById(int id);

        //POST - Adicionar Estudante
        Task<ServiceResponse<List<Estudante>>> AddEstudante(Estudante newEstudante);
    }
}