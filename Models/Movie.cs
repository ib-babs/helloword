using System.ComponentModel.DataAnnotations;

namespace helloword.Models
{
#pragma warning disable CS8618
    public class Movie
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Please enter movie title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter movie date")]
        public DateOnly ReleasedDate { get; set; }

        [Required(ErrorMessage = "Please enter movie price")]
        public decimal Price { get; set; }
    }
}
