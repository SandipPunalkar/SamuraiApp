namespace SamuraiApp.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }

        //Navigation Property
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
    }
}