using System;
using System.ComponentModel.DataAnnotations;



namespace GestionInscription.Model
{
    public class Adherant
    {
        [Key]
        public Guid AdherantGuid { get; set; }

        public string Nom { get; set; }

        public string PreNom { get; set; }








    }
}
