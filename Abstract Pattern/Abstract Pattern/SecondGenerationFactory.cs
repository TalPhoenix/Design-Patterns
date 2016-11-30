using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pattern
{
    public class SecondGenerationFactory : PokemonFactory
    {
        public override Wild CreateWildPokemon()
        {
            return new Mareep();
        }

        public override Captured CreateCapturedPokemon()
        {
            return new Cindaquill();
        }
    }
}
