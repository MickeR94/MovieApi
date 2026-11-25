using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models
{
    public class Review
    {
        public int Id { get; set; }
        public required string ReviewerName { get; set; }
        public string Comment { get; set; } = string.Empty;
        [Range(1,5, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public int Rating { get; set; }

        // Foreign key till Movie - as per "Modellklasser" in "Entity Framework" lecture
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
    }
}
