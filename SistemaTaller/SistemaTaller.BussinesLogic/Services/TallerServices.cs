using SistemaTaller.DataAccess.Repositories;
using SistemaTaller.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.BussinesLogic.Services
{
    public class TallerServices
    {

        private readonly UsuariosRepository _usuarioRepository;

        public TallerServices(UsuariosRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
           

        }
        #region Usuarios
       

        public IEnumerable<Usuario> ListUsuario()
        {
            var result = new ServiceResult();
            try
            {
                var list = _usuarioRepository.List();
                return list;
            }
            catch (Exception ex)
            {

                IEnumerable<Usuario> usua = null;
                return usua;
            }
        }



  

        #endregion

    }
}
