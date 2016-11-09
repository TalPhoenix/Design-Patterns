using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class RefinedAbstraction : Abstraction
    {
        // Constructor
        public RefinedAbstraction(string group)
          : base(group)
        {
        }

        public override string ShowAll()
        {
            string _MovieList = "";
            _MovieList = base.ShowAll();
            return _MovieList;
        }
    }
}
