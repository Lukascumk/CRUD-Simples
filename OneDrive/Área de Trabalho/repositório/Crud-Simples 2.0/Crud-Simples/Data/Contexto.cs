using Crud_Simples.Models;
using Microsoft.EntityFrameworkCore;


namespace Crud_Simples.Data
{
    public class Contexto : DbContext 
    {

        public Contexto(DbContextOptions<Contexto> options)
            
            :base(options) 
        { }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
