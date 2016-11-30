using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public class Strategy : Game
    {
        public override void CreateElements()
        {
            Games.Add(new Objective());
            Games.Add(new HowToPlay());
        }
    }
}
