using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaTaller.BussinesLogic.Services;
using Microsoft.EntityFrameworkCore;
using SistemaTaller.Entities.Entities;
using SistemaTaller.Entities;

namespace SistemaTaller.API.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly TallerServices _tallerServices;
        private readonly IMapper _mapper;


        public UsuarioController(TallerServices tallerServices, IMapper mapper)
        {
            _tallerServices = tallerServices;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet("/ListarUsuario")]
        public IActionResult List()
        {
            var list = _tallerServices.ListUsuario();
            return Ok(list);
        }

    }
}
