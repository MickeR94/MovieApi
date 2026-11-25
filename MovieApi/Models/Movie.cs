namespace MovieApi.Models
{
    public class Movie
    {
        public int Id { get; set; } // for this use case I chose int instead of Guid
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Genre { get; set; } = string.Empty;
        public int Duration { get; set; }

        // Link to MovieDetails
        public MovieDetails? MovieDetails { get; set; }

        // Link to Review. A list since we want 1:M - relation. Initially used "List<Review>?" since it can be null (empty list = no reviews), but later switched to = new();
        public List<Review> Reviews { get; set; } = new();

        // Link to Actor
        public List<Actor> Actors { get; set; } = new();
    }
}
