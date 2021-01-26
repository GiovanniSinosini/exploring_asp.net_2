using Clinica_Veterinaria_3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Veterinaria_3.Data
{
    public class ConsultaContext : DbContext
    {
        public ConsultaContext(DbContextOptions<ConsultaContext> options): base(options)
        {

        }

        public DbSet<Consulta> Consulta { get; set; } 

    }
}
