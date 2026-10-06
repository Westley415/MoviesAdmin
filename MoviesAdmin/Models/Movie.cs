namespace MoviesAdmin.Models
{
    public class Movie
    {
        // this will be theUnique identifier for the database
        public int Id { get; set; }

        //  this is the Title of the movie
        public string Title { get; set; } = string.Empty;

        // this is the synopsis of the movie
        public string Synopsis { get; set; } = string.Empty;

        // this is the genre of the movie
        public string Genre { get; set; } = string.Empty;

        // this is the rating of the movie
        public string Rating { get; set; } = string.Empty;

        // this is the duration of the movie
        public string Minutes { get; set; } = string.Empty;
        
        // this will be the release date of the movie
        public string Releasedate { get; set; } = string.Empty;
    }
}
