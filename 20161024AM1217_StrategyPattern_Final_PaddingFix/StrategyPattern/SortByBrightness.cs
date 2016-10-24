using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SortByBrightness : SortMethods   //This is my ConcreteStrategyB
    {
        public override void Sort(colorAttribute[] colorList)
        {
            Global.gv_DisplayData = "";
            IEnumerable<colorAttribute> query2 = colorList.OrderBy(colorattribute => colorattribute.Brightness);
            string paddingstr = "";

            foreach (colorAttribute colorattribute in query2)
            {
                if (colorattribute.Name.ToString().Length <= 8)
                {
                    paddingstr = "\t";
                }
                Global.gv_DisplayData = Global.gv_DisplayData + " Name: " + colorattribute.Name.ToString() + ";" + paddingstr + "\t \t Brightness: " + colorattribute.Brightness.ToString() + ";\t \t \t ArgbValue: " + colorattribute.ArgbValue.ToString() + "\r\n";
                // Global.gv_DisplayData = Global.gv_DisplayData + "Actual Color Brightness value: " + System.Drawing.Color.FromName(colorattribute.Name.ToString()).GetBrightness().ToString() + "\r\n";
                paddingstr = "";
            }
        }
    }
}
