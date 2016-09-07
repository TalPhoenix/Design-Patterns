using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class ConcreteAggregate : Aggregate // this is the class concrete aggregate
    {
        
        public ConcreteAggregate()
        {
            Elements = new List<int>();
        }
        public override Iterator createIterator()
        {
            return new ConcreteIterator(this);
        }

        public override IteratorTwo createIteratorTwo()
        {
            return new ConcreteIteratorTwo(this);
        }
    }
}
