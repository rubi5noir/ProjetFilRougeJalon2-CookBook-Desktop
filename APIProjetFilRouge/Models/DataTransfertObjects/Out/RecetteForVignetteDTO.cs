namespace APIProjetFilRouge.Models.DataTransfertObjects.Out
{
#pragma warning disable S101 // Types should be named in PascalCase
    public class RecetteForVignetteDTO
#pragma warning restore S101 // Types should be named in PascalCase
    {
        public int id { get; set; }
        public string? nom { get; set; }
        public string? description { get; set; }
        public string? img { get; set; }
        public double noteMoyenne { get; set; }
    }
}
