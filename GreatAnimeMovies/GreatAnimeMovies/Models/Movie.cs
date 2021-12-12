using System;
using System.ComponentModel.DataAnnotations;

namespace GreatAnimeMovies.Models
{
    public enum Genre
    {
        Action, Adventure, Comedy, Drama, SliceOfLife, Fantasy, Supernatrual, Horror, Mystery, Psychological, Romance, SciFi, Historical
    }

    public enum MPAARating
    {
        G, PG, PG13, R, NC17
    }

    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Production Studio")]
        public string ProductionStudio { get; set; }
        public string Director { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Dubbed in English")]
        public bool EnglishDub { get; set; }

        [Display(Name = "MPAA Rating")]
        public MPAARating MPAARating { get; set; }
    }
}
