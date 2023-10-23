namespace NZwalks.Model.Domains
{
    public class Walkdifficulty
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double length { get; set; }
        public Guid RegionId { get; set; }
        public Guid walkdifficultyId { get; set; }
    }
}
