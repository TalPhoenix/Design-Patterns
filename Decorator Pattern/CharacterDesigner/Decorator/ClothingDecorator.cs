using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesigner.Decorator
{
    class ClothingDecorator : CostumeComponent
    {
        CostumeComponent m_BaseComponent = null;

        protected string m_Name = "Undefined Decorator";
        protected double m_Price = 0.0;
        protected string m_Size = "Undefined Decorator";

        protected ClothingDecorator(CostumeComponent baseComponent)
        {
            m_BaseComponent = baseComponent;
        }

        public override string GetName(string charactername)
        {
            return string.Format("{0}, {1}", m_BaseComponent.GetName(m_Name), charactername);
        }

        public override double GetPrice(double price)
        {
            return price + m_BaseComponent.GetPrice(m_Price);
        }

        public override string GetSize(string size)
        {
            return size + m_BaseComponent.GetSize(m_Size);
        }
    }
}
