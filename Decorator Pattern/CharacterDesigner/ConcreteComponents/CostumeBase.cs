using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterDesigner.ConcreteComponents
{
    class CostumeBase : CostumeComponent
    {
        private string v;

        public CostumeBase(string v)
        {
            this.v = v;
        }

        public override string GetName(string name)
        {
            return name;
        }

        public override double GetPrice(double price)
        {
            return price;
        }

        public override string GetSize(string size)
        {
            return size;
        }
    }
}
