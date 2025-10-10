using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookAppDesktop.Models.DTO
{
    internal class RecetteDetailsDTO
    {
        public int id { get; set; }
        public string identifiantCreateur { get; set; } = "";
        public string nom { get; set; }
        public string description { get; set; }
        public TimeSpan temps_preparation { get; set; }
        public TimeSpan temps_cuisson { get; set; }
        public TimeSpan temps_total { get { return temps_preparation + temps_cuisson; } }
        public int difficulte { get; set; }

        public List<IngredientDTO> ingredients { get; set; }

        public List<EtapeDTO> etapes { get; set; }

        public List<CategorieDTO> categories { get; set; }

        //public Compte? utilisateur { get; set; }

        //public List<AvisOfRecetteDTO> avis { get; set; }


        public string? img { get; set; }
    }

}

