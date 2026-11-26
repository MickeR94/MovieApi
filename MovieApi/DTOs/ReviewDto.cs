using System.ComponentModel.DataAnnotations;

namespace MovieApi.DTOs
{
    // I removed the criterias because I want this to be a "read-DTO"
    public class ReviewDto
    {
        //[Required(ErrorMessage = "Must specify an author of the review")]
        public required string ReviewerName { get; set; }

        //[MaxLength(200, ErrorMessage = "The review can be 200 characters max")]
        public string Comment { get; set; } = string.Empty;

        //[Range(1, 5, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public int Rating { get; set; }
    }
}
