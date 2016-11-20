using CharacterDesigner.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesigner.ConcreteDecorators
{
    class CharacterMaskDecorator : ClothingDecorator
    {
        public CharacterMaskDecorator(CostumeComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Head Mask";
            this.m_Price = 45.0;
            this.m_Size = "";
        }
    }
}