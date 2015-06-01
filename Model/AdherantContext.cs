using System.Data.Entity;


namespace GestionInscription.Model
{
    public class AdherantContext : DbContext
    {

        public AdherantContext() : base("name=defaultConnection")
        {
           
        }


   
        public virtual DbSet<Adherant> Adherants { get; set; }


        public virtual DbSet<Inscription> Inscriptions { get; set; }

    }
}
