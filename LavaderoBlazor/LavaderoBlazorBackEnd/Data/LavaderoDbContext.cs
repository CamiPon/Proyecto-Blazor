using LavaderoBlazorBackEnd.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoBlazorBackEnd.Data
{
    public class LavaderoDbContext : DbContext
    {
        public LavaderoDbContext(DbContextOptions<LavaderoDbContext> options) : base(options)
        { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Lavado> Lavados { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}
