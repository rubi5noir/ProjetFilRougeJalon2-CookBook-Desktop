using System.ComponentModel.DataAnnotations;

namespace APIProjetFilRouge.Models.DataTransfertObjects.Out
{
    public class CompteDetailsDTO
    {
        public int id { get; set; }
        public string identifiant { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        public bool admin { get; set; }
        public string Role => admin ? "Admin" : "User";
    }
}
