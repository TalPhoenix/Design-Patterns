using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesigner.ConcreteComponents
{
    class CostumeCharacter : CharacterComponent
    {
        private string v;

        public CostumeCharacter(string v)
        {
            this.v = v;
        }

        public override string GetCharacter(string charactername)
        {
            return charactername;
        }

    }
}
