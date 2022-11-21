using Microsoft.EntityFrameworkCore;
using Sis.Models;

namespace Sis.Data
{
    public class Konteksti:DbContext
    {
        public Konteksti(DbContextOptions<Konteksti> options):base(options)
        {
            
        }

        public DbSet<Student> Studentet { get; set; }
        public DbSet<Komuna>  Komunat { get; set; }
    }
}
