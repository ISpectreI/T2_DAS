using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2_Alexander_Solis.Models;
namespace T2_Alexander_Solis.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
            {

            }
        public DbSet<Distribuidor> Distribuidor { get; set; }
    }
}
