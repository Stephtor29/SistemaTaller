using Dapper;
using Microsoft.Data.SqlClient;
using SistemaTaller.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.DataAccess.Repositories
{
    public class UsuariosRepository : iRepository<Usuario>
    {
        public RequestStatus Delete(Usuario item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Find(Usuario? item)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(Usuario item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> List()
        {
            var parameter = new DynamicParameters();


            using var db = new SqlConnection(SistemaDeTallerContext.ConnectionString);
            var result = db.Query<Usuario>(ScriptDataBase.Usuarios_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();


            return result;
        }

        public RequestStatus Update(Usuario item)
        {
            throw new NotImplementedException();
        }
    }
}
