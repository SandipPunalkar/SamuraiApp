﻿namespace SamuraiApp.Domain
{
    public class Battle
    {
        public Battle()
        {
            SamuraisBattles = new List<SamuraiBattle>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<SamuraiBattle> SamuraisBattles { get; set; }
    }
}