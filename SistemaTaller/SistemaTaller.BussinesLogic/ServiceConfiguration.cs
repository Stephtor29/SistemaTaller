using Microsoft.Extensions.DependencyInjection;
using SistemaTaller.BussinesLogic.Services;
using SistemaTaller.DataAccess;
using SistemaTaller.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.BussinesLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAccess(this IServiceCollection services, string connectionString)
        {
           
            services.AddScoped<UsuariosRepository>();




            SistemaDeTallerContext.BuildConnectionString(connectionString);
        }


        public static void BusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<TallerServices>();
        }
    }
}
