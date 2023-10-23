namespace NZwalks.Model.Domains
{
    public class Walk
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public double length { get; set; }

        public Guid Regionid { get; set; }
        public Guid  walkdifficultyId { get; set; }

        //Navigation property
        public Regions Regions { get; set; }
        public Walkdifficulty Walkdifficulty { get; set; }


    }
}
