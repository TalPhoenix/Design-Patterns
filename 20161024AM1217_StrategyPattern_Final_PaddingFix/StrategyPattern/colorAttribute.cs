using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class colorAttribute     //This is my Context Class
    {
        public string Name { get; set; }
        public string Brightness { get; set; }
        public string ArgbValue { get; set; }

        private SortMethods _sortmethods;

        public void SetColorSortMethod(SortMethods sortmethods)
        {
             this._sortmethods = sortmethods;
        }

        public void Sort(colorAttribute[] _colorList)
        {
             _sortmethods.Sort(_colorList);

             Console.WriteLine("Executed Sort");
        }

        
    }
}
