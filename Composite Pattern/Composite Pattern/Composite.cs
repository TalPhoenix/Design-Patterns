using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Composite : Component
    {
        private List<Component> elements = new List<Component>();

        // Constructor

        public Composite(string name)
            : base(name)
        {

        }

        public override void Add(Component d)
        {
            elements.Add(d);
        }

        public override void Remove(Component d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+ " + _name);
            // Display each child element on this node
            foreach (Component d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}
