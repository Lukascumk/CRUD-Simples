using Crud_Aspdotnet_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Aspdotnet_MVC.Data
{
    public class Contexto :DbContext
    {

#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public Contexto(DbContextOptions<Contexto>options)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

            : base(options)
        { }


        public DbSet<Usuario> Usuario { get; set; }



    }
}
