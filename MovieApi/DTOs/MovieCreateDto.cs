using System.ComponentModel.DataAnnotations;

namespace MovieApi.DTOs
{
    public class MovieCreateDto
    {
        [Required(ErrorMessage = "Filmnamn måste vara med")]
        public string Title { get; set; }

        [Range(1888,2026, ErrorMessage = "Välj ett giltigt årtal")]
        public int Year { get; set; }

        [MaxLength(20, ErrorMessage = "Genren kan inte vara längre än 20 tecken")]
        public string Genre { get; set; }

        // Longest movie ever is 51420 minutes
        [Range(60, 51420, ErrorMessage = "Please enter a valid runtime in minutes")]
        public int Duration { get; set; }

    }
}
