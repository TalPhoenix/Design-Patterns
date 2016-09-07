using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public abstract class Aggregate // this is the aggregate class
    {
        public List<int> Elements;

        public abstract Iterator createIterator();

        public abstract IteratorTwo createIteratorTwo();
    }
}
