using CharacterDesigner.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesigner.ConcreteDecorators
{
    class CharacterShoesDecorator : ClothingDecorator
    {
        public CharacterShoesDecorator(CostumeComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Shoes";
            this.m_Price = 20.0;
            this.m_Size = "";
        }
    }
}
