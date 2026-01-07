using AutoMapper;
using SistemaTaller.API.Models;
using SistemaTaller.Entities.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaTaller.API.Extensions
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<Usuario, UsuariosViewModel>().ReverseMap();
        }



    }
}
