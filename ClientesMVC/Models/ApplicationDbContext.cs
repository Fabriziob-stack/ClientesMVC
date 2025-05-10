using System.Data.Entity;

namespace ClientesMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}