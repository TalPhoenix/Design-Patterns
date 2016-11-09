using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class ConcreteImplementor : Implementor
    {
        public List<string> _movies = new List<string>();
        private int _current = 0;

        public ConcreteImplementor()
        {
            _movies.Add("Howl's Moving Castle");
            _movies.Add("Spirited Away");
            _movies.Add("Star Trek");
            _movies.Add("A Knights Tale");
            _movies.Add("Troy");
            _movies.Add("Stardust");
        }

        public override int NextMovie()
        {
            if (_current <= _movies.Count - 1)
            {
                 _current++;
            }
            return _current;
        }

        public override int PriorMovie()
        {
            if (_current > 0)
            {
                _current--;
            }
            return _current;
        }

        public override string AddMovie(string movies)
        {
            _movies.Add(movies);
            return movies;
        }

        public override string ShowMovie()
        {
            return _movies[_current];
        }

        public override string ShowAllMovies()
        {
            string MovieList = "";
            foreach (string movies in _movies)
            {
                MovieList = MovieList + movies + "\r\n";
            }
            return MovieList;
        }

        public override int FirstMovie()
        {
            _current = 0;
            return _current;
        }

        public override int LastMovie()
        {
            _current = _movies.Count - 1;
            return _current;
        }

        public override int MovieCount()
        {
            _current = _movies.Count;
            return _current;
        }
    }
}
