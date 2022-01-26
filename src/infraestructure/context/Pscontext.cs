using Microsoft.EntityFrameworkCore;
using infraestructure.models;
using infraestructure.Helpers;
using System;
using Microsoft.Extensions.Configuration;

namespace infraestructure.context
{
    public class Pscontext : DbContext
    {
        public IConfiguration configuration { get; set; }
        public Pscontext()
        { 
            configuration = AppSettings.GetConfiguration();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));


        public DbSet<PersonaModel> Personas { get; set; }
    }
}