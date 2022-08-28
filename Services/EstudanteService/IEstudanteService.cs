using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudantes_Dotnet.Services.EstudanteService
{
    public interface IEstudanteService
    {
        //GET - Pegar todos os Estudantes
        Task<List<Estudante>> GetAllEstudantes();

        //GET - Pegar o Estudante por Id específico
        Task<Estudante> GetEstudanteById(int id);

        //POST - Adicionar Estudante
        Task<List<Estudante>> AddEstudante(Estudante newEstudante);
    }
}