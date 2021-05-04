using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using LavaderoBlazorBackEnd.Data;
using LavaderoBlazorBackEnd.Data.Entities;

namespace LavaderoBlazorBackEnd.Services
{
    class LavaderoService
    {
        private readonly LavaderoDbContext db;
        public LavaderoService(LavaderoDbContext dbContext)
        {
            db = dbContext;
        }
        public async Task<Cliente> GetCliente(Int32 idCliente)
        {
            var cliente = await db.Clientes
                .AsNoTracking()
                .Where(x => x.IDCliente == idCliente)
                .FirstOrDefaultAsync();
            return cliente;
        }

    }
}
