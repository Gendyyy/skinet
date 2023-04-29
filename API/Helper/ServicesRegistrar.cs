using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Helper
{
    public static class ServicesRegistrar
    {
         public static void Register(this WebApplicationBuilder builder){
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<StoreContext>(opt=>
            {
               opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}