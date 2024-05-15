using Crud_Aspdotnet_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Aspdotnet_MVC.Data
{
    public class Contexto :DbContext
    {

        public Contexto(DbContextOptions<Contexto>options)
        
            :base(options)
        { }


        public DbSet<Usuario> Usuario { get; set; }



    }
}
