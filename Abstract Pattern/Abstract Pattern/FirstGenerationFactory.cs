using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pattern
{
    public class FirstGenerationFactory : PokemonFactory
    {
        public override Wild CreateWildPokemon()
        {
            return new Dratini();
        }

        public override Captured CreateCapturedPokemon()
        {
            return new Charamander();
        }
    }
}
