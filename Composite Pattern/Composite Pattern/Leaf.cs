using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Composite_Pattern
{
    public class Leaf : Component
    {

        // Constructor
        public Leaf(string name)
          : base(name)
        {

        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a Leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a Leaf");
        }

        //public override void Display(int indent)
        //{
        //    Console.WriteLine(new String('-', indent) + " " + _name);
        //}

        public override void Display(int indent)
        {
            string itemName = "";
            string itemPriceStr = "";
            decimal itemPrice = 0;
            char[] delimiterChars = {'|'};
            string[] words = _name.Split(delimiterChars);
            itemName = words[0].ToString();
            itemPriceStr = words[2].ToString();
            itemPrice = Convert.ToDecimal(itemPriceStr);
            Console.WriteLine(new String('-', indent) + " " + _name);
            Global.gv_TotalPrice = Global.gv_TotalPrice + itemPrice;
            Global.gv_DisplayData = Global.gv_DisplayData + "   - " + itemName + " - Price: $" + itemPriceStr + "\r\n";
        }
    }
}
