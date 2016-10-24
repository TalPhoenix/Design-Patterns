using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SortByArgbValue : SortMethods   //This is my ConcreteStrategyC
    {
        public override void Sort(colorAttribute[] colorList)
        {
            Global.gv_DisplayData = "";
            IEnumerable<colorAttribute> query3 = colorList.OrderBy(colorattribute => colorattribute.ArgbValue);

            foreach (colorAttribute colorattribute in query3)
            {
                Global.gv_DisplayData = Global.gv_DisplayData + " Name: " + colorattribute.Name.ToString() + ";\t \t Brightness: " + colorattribute.Brightness.ToString() + ";\t \t \t ArgbValue: " + colorattribute.ArgbValue.ToString() + "\r\n";
               // Global.gv_DisplayData = Global.gv_DisplayData + "Actual Color Brightness value: " + System.Drawing.Color.FromName(colorattribute.Name.ToString()).GetBrightness().ToString() + "\r\n";
            }
        }
    }
}
