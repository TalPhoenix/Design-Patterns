using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public class RPG : Game
    {
        public override void CreateElements()
        {
            Games.Add(new Characters());
            Games.Add(new Skills());
            Games.Add(new World());
            Games.Add(new Objective());
            Games.Add(new Map());
            Games.Add(new ThreeDLayout());
        }
    }
}
