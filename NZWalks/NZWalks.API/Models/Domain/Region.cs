namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double lat { get; set; }
        public double log { get; set; }
        public long population { get; set; }
        public IEnumerable<Walk> Walks { get; set; }

    }

}
