using System.ComponentModel.DataAnnotations;

namespace APIProjetFilRouge.Models.DataTransfertObjects.Out
{
#pragma warning disable S101 // Types should be named in PascalCase
    public class CompteDTO
#pragma warning restore S101 // Types should be named in PascalCase
    {
        public int id { get; set; }
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string identifiant { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
    }
}
