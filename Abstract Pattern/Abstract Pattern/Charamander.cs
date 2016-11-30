using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pattern
{
    public class Charamander : Captured
    {
        //need to make a public variable that can be used by the classes 

        public override string Battle(Wild w)
        {
            return this.GetType().Name + " battles " + w.GetType().Name;
        }
    }
}
