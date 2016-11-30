using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pattern
{
    public abstract class PokemonFactory
    {
        public abstract Wild CreateWildPokemon();
        public abstract Captured CreateCapturedPokemon();
    }
}
