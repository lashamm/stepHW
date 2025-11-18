using System.Security;

namespace hwC_Step.old.Models
{
    enum Genre
    {
        SciFi,
        Drama,
        Horror,
        Comedy
    }

    /// <summary>
    /// 
    /// </summary>
    internal class Movie
    {
        private int _releaseYear;
        private string? _title;
        private string? _director;

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _title = value;
            }
        }

        public string Director
        {
            get => _director;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _director = value;
            }
        }

        /// <summary>
        /// Movie's Release Year.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">1990-current year.</exception>
        public int ReleaseYear
        {
            get => _releaseYear;
            set
            {
                if (value < 1990 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _releaseYear = value;
            }
        }

        public Genre Genre { get; set; }

        public Movie(
            string title,
            string director,
            int releaseYear,
            Genre genre)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Title: {Title}, " +
                $"Director: {Director}, " +
                $"ReleaseYear {ReleaseYear}, " +
                $"Genre: {Genre}";
        }
    }
}
