using System.ComponentModel.DataAnnotations;
namespace MoviesAdmin.Models
{
    public class Movie
    {
        // this will be theUnique identifier for the database
        public int Id { get; set; }

        //  this is the Title of the movie
        [Required]
        [Display(Name  = "Name of Movie")]
        [StringLength (50)]
        public string Title { get; set; } = string.Empty;

        // this is the synopsis of the movie
        [Required]
        [Display(Name  = "Discription")]
        [StringLength (600)]
        public string Synopsis { get; set; } = string.Empty;

        // this is the genre of the movie
        [Required]
        [Display(Name  = "Genres")]
        [StringLength (40)]
        public string Genre { get; set; } = string.Empty;

        // this is the rating of the movie
        [Required]
        [Display(Name = "Classification")]
        [StringLength (20)]
        public string Rating { get; set; } = string.Empty;

        // this is the duration of the movie
        [Required]
        [Display(Name = "Run Time Minutes")]
        [Range(30, 210)]
        public string Minutes { get; set; } = string.Empty;

        // this will be the release date of the movie
        [Required]
        [Display(Name = "Release Date")]
        public DateTime Releasedate { get; set; } = DateTime.Now;
    }
}
