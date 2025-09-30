namespace APIProjetFilRouge.Models.BussinessObjects
{
    public class Categorie
    {
        public int id { get; set; }
        public string nom { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Categorie categorie &&
                   id == categorie.id;
        }
    }
}
