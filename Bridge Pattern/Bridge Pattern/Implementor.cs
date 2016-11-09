using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    abstract class Implementor
    {
        public abstract int NextMovie();
        public abstract int PriorMovie();
        public abstract string AddMovie(string name);
        public abstract string ShowMovie();
        public abstract string ShowAllMovies();
        public abstract int FirstMovie();
        public abstract int LastMovie();
        public abstract int MovieCount();
    }
}
