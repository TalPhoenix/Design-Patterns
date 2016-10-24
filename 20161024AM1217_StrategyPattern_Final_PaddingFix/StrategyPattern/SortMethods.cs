using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class SortMethods      //This is my Strategy Class
    {
        //Need to create method that can be overriden with all the different sort strategies
        public abstract void Sort(colorAttribute[] colorList);
    }

}
