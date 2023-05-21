using Microsoft.EntityFrameworkCore;
using Clientes.Models;

namespace Clientes.DAL
{
    public class ClientesContext : DbContext
    {
        public DbSet<Clientess> clientes { get; set; }


        public ClientesContext(DbContextOptions<ClientesContext> options) : base(options) { }


    }
}
