namespace Log4netSample.Model
{
    public class Media  
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public MediaType MediaType { get; set; }
        public Platform Platform { get; set; }
        public Genre Genre { get; set; }
     
    }

    public enum MediaType
    {
        Print,
        CD,
        DVD,
        BlueRay,
        Game

    }

    public enum Platform
    {
        Xbox,
        Playstation,
        Nintendo,
        Pc,
        Board,
        Book,
        Movie
    }

    public enum Genre
    {
        Comedy,
        Fiction,
        Biography,
        Shooter,
        ActionAdventure,
        Rpg
    }
}

