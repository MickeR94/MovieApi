namespace MovieApi.DTOs
{
    public class MovieStatsDto
    {
        public string Synopsis { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public decimal Budget { get; set; }
    }
}
