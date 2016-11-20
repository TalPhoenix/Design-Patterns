using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesigner
{
    public abstract class CharacterComponent
    {
        public abstract string GetCharacter(string charactername);
    }

    public abstract class CostumeComponent
    {
        public abstract string GetName(string name);
        public abstract double GetPrice(double price);
        public abstract string GetSize(string size);
    }
}
