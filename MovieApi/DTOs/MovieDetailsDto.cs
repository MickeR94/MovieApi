namespace MovieApi.DTOs
{
    public class MovieDetailsDto
    {
        //MovieDto + MovieStatsDto + ActorDto + ReviewDto
        public MovieStatsDto MovieStats { get; set; } = new();

        public MovieDto Movie { get; set; } = new();

        public List<ReviewDto> Reviews { get; set; } = new ();
        public List<ActorDto> Actors { get; set; } = new ();

    }
}
