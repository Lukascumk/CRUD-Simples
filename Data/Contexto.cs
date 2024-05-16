using Microsoft.EntityFrameworkCore;
using Crud_Aspdotnet_MVC.Models;

namespace Crud_Aspdotnet_MVC.Data
{
    public class Contexto :DbContext
    {


        public Contexto(DbContextOptions<Contexto> options)

            : base(options)
        { }


        public DbSet<Usuario> Usuario { get; set; }



    }
}
