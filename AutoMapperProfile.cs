using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Estudantes_Dotnet.Dtos.Estudante;

namespace Estudantes_Dotnet
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Estudante, GetEstudanteDto>();
            CreateMap<AddEstudanteDto, Estudante>();
        }
    }
}