using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class ConcreteSender : Sender    //Concrete Subject
    {
        // Constructor
        public ConcreteSender(string message, string subject, string mailTo)
          : base(message, subject, mailTo)
        {
        }
    }
}
