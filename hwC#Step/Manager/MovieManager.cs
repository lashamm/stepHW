using ConsoleApp_418_FinalProject.Models;

namespace ConsoleApp_418_FinalProject.Manager
{
    internal class MovieManager : Icrud
    {
        private List<Movie> _movies;

        public MovieManager()
        {
            _movies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public void ShowAll()
        {
            _movies.ForEach(Console.WriteLine);
        }

        public bool GetMovie(string title, out Movie? movie)
        {
            Func<Movie, bool> func = (movie => movie.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            bool result = _movies.Any(func);

            movie = _movies.FirstOrDefault(func);

            return result;
        }

        public bool GetMovies(string director, out List<Movie> movies)
        {
            Func<Movie, bool> func = movie => movie.Director.Equals(director, StringComparison.OrdinalIgnoreCase);

            bool result = _movies.Any(func);

            movies = _movies.Where(func).ToList();

            return result;
        }

        public bool UpdateMovie(string title, Genre newGenre)
        {
            bool result = GetMovie(title, out Movie? movie);

            if (movie != null)
            {
                movie.Genre = newGenre;
            }

            return result;
        }

        public bool DeleteMovie(string title)
        {
            bool result = GetMovie(title, out Movie? movie);

            if (movie != null)
            {
                _movies.Remove(movie);
            }

            return result;
        }
    }
}
