namespace SamuraiApp.Domain
{
    public class Samurai
    {
        public Samurai()
        {
            Quotes = new List<Quote>();
            SamuraiBattles = new List<SamuraiBattle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public Clan Clan { get; set; }


        //many to many
        public List<SamuraiBattle> SamuraiBattles { get; set; }

        // one to one     
       // public Horse Horse { get; set; }
    }
}