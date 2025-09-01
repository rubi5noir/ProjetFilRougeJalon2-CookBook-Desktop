namespace APIProjetFilRouge.Models.BussinessObjects
{
    public class Avis
    {
        public int note { get; set; }
        public string commentaire { get; set; }

        public int id_recette { get; set; }
        public int id_utilisateur { get; set; }
    }
}
