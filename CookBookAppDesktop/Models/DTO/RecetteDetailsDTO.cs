using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookAppDesktop.Models.DTO
{
#pragma warning disable S101 // Types should be named in PascalCase
    internal class RecetteDetailsDTO
#pragma warning restore S101 // Types should be named in PascalCase
    {
        public int id { get; set; }
        public string identifiantCreateur { get; set; } = "";
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string nom { get; set; }
        public string description { get; set; }
        public TimeSpan temps_preparation { get; set; }
        public TimeSpan temps_cuisson { get; set; }
        public TimeSpan temps_total { get { return temps_preparation + temps_cuisson; } }
        public int difficulte { get; set; }

        public List<IngredientDTO> ingredients { get; set; }

        public List<EtapeDTO> etapes { get; set; }

        public List<CategorieDTO> categories { get; set; }

        public List<AvisDTO> avis { get; set; }

#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.

        public string? img { get; set; }
    }

}

