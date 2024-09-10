using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Datos.Repositorios;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Servicios.Servicios;

namespace TP01EF2024.InversionOfControl
{
    public static class DI
    {
        public static void ConfigurarServicios(IServiceCollection servicios, IConfiguration configuration)
        {

            //REPOSITORIOS

            servicios.AddScoped<IBrandsRepository, BrandsRepository>();

            servicios.AddScoped<IColoursRepository, ColoursRepository>();

            servicios.AddScoped<ISportsRepository, SportsRepository>();

            servicios.AddScoped<IGenresRepository, GenresRepository>();

            servicios.AddScoped<IShoesRepository, ShoesRepository>();

            servicios.AddScoped<ISizesRepository, SizesRepository>();

            //SERVICIOS

            servicios.AddScoped<IBrandsService, BrandsService>();

            servicios.AddScoped<IColoursService, ColoursService>();

            servicios.AddScoped<ISportsService, SportsService>();

            servicios.AddScoped<IGenresService, GenresService>();

            servicios.AddScoped<IShoesService, ShoesService>();

            servicios.AddScoped<ISizesService, SizesService>();

            //UNIT

            servicios.AddScoped<IUnitOfWork, UnitOfWork>();

            servicios.AddDbContext<TP01DbContext>(optiones =>
            {
                optiones.UseSqlServer(configuration.GetConnectionString("MyConn"));
            });

        }

    }
}
