﻿namespace APIProjetFilRouge.Models.BussinessObjects
{
    public class Categorie
    {
        public int id { get; set; }
        public string nom { get; set; }

        public List<Recette> recettes { get; set; }
    }
}
