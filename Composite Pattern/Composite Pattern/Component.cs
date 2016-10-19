using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public abstract class Component
    {
        protected string _name;
        // Constructor
        public Component(string name)
        {
            this._name = name;
        }
        public abstract void Add(Component d);

        public abstract void Remove(Component d);

        public abstract void Display(int indent);

    }
}
