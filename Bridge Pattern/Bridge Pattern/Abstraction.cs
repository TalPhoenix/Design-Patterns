using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class Abstraction
    {
        private Implementor _dataObject;
        protected string group;

        public Abstraction(string group)
        {
            this.group = group;
        }

        public Implementor Genre
        {
            set { _dataObject = value; }
            get { return _dataObject; }
        }

        public virtual int Next()
        {
           return _dataObject.NextMovie();
        }

        public virtual int Prior()
        {
            return _dataObject.PriorMovie();
        }

        public virtual string Add(string movies)
        {
            return _dataObject.AddMovie(movies);
        }

        public virtual string Show()
        {
            return _dataObject.ShowMovie();
        }

        public virtual string ShowAll()
        {
            return _dataObject.ShowAllMovies();
        }

        public virtual int First()
        {
            return _dataObject.FirstMovie();
        }

        public virtual int Last()
        {
            return _dataObject.LastMovie();
        }

        public virtual int Count()
        {
            return _dataObject.MovieCount();
        }
    }
}
