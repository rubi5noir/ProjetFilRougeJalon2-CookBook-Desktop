using System.ComponentModel.DataAnnotations;

namespace APIProjetFilRouge.Models.BussinessObjects
{
    public class Compte
    {
        public int id { get; set; }
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string identifiant { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

        public bool admin { get; set; }
        public string Role => admin ? "Admin" : "User";
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
    }
}
