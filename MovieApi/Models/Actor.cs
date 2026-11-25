namespace MovieApi.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int BirthYear { get; set; } // DateTime is for full date, I only want year so chose int
        
        // Add foreign key for Movie. Made it a list because it's a N:M-relationship
        // public int MovieId { get; set; } <-- not needed since an actor can be inb many movies
        public List<Movie> Movies { get; set; } = new();
    }
}
