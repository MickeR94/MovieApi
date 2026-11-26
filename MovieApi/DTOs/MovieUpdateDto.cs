using System.ComponentModel.DataAnnotations;

namespace MovieApi.DTOs
{
    public class MovieUpdateDto
    {
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Filmtiteln får vara -50 tecken")]
        public string Title { get; set; }
    }
}
