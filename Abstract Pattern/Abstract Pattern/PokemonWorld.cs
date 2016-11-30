using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pattern
{
    public abstract class PokemonWorld
    {
        private Wild _wild;
        private Captured _captured;

        public PokemonWorld(PokemonFactory factory)
        {
            _wild = factory.CreateWildPokemon();
            _captured = factory.CreateCapturedPokemon();
        }

        public string Battle()
        {
            return _captured.Battle(_wild);
        }
    }
}
