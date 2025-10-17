namespace APIProjetFilRouge.Models.BussinessObjects
{
#pragma warning disable CS0659 // Le type se substitue à Object.Equals(object o) mais pas à Object.GetHashCode()
#pragma warning disable S1206 // "Equals(Object)" and "GetHashCode()" should be overridden in pairs
    public class Categorie
#pragma warning restore S1206 // "Equals(Object)" and "GetHashCode()" should be overridden in pairs
#pragma warning restore CS0659 // Le type se substitue à Object.Equals(object o) mais pas à Object.GetHashCode()
    {
        public int id { get; set; }
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string nom { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.

        public override bool Equals(object? obj)
        {
            return obj is Categorie categorie &&
                   id == categorie.id;
        }
    }
}
