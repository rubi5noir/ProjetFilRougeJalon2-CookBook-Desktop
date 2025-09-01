namespace APIProjetFilRouge.Models.DataTransfertObjects.Out
{
    public class RecetteForVignetteDTO
    {
        public int id { get; set; }
        public string? nom { get; set; }
        public string? description { get; set; }
        public string? img { get; set; }
        public double noteMoyenne { get; set; }
    }
}
