using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public abstract class Game //Creator Abstract Class
    {
        private List<GameElements> _gameElements = new List<GameElements>();

        public Game()
        {
            this.CreateElements();
        }

        public List<GameElements> Games
        {
            get { return _gameElements; }
        }

        public abstract void CreateElements();
    }
}
