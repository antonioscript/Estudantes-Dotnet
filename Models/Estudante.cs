using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudantes_Dotnet.Models
{
    public class Estudante
    {
        public int Id { get; set; }

        public string Nome { get; set; } = "Antônio";

        public int Idade { get; set; } = 25;

        public string Curso { get; set; } = "Engenharia de Software";

        public NivelGraduacao Nivel { get; set; } = NivelGraduacao.Bacharelado;
    }
}