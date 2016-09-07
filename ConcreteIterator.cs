using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern 
{
    public class ConcreteIterator : Iterator //this is the concrete iterator class
    {
        Aggregate aggregate;
        int currentItem;

        public ConcreteIterator(Aggregate agg)
        {
            aggregate = agg;
        }

        public override object First()
        {
            currentItem = 0;
            return CurrentItem();
        }

        public override object Next()
        {
            if (!IsDone())
                currentItem++;
            return CurrentItem();
        }

        public override bool IsDone()
        {
            return (currentItem > aggregate.Elements.Count - 1);
        }

        public override object CurrentItem()
        {
            if (IsDone())
                return null;
            return aggregate.Elements[currentItem];
        }
    }
}
