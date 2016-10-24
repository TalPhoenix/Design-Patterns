using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        colorAttribute colorattribute = new colorAttribute();

        //public static string gv_DisplayData = "";
        colorAttribute[] colorList = { new colorAttribute {Name="Red", Brightness="0.5", ArgbValue="255,255,000,000" },
                                       new colorAttribute {Name="Blue", Brightness="0.5", ArgbValue="255,000,000,255" },
                                       new colorAttribute {Name="Green", Brightness="0.2509804", ArgbValue="255,000,255,000" },
                                       new colorAttribute {Name="Orange", Brightness="0.5", ArgbValue="255,255,165,000" },
                                       new colorAttribute {Name="Purple", Brightness="0.2509804", ArgbValue="255,128,000,128" },
                                       new colorAttribute {Name="SlateBlue", Brightness="0.5784314", ArgbValue="255,106,090,205" },
                                       new colorAttribute {Name="Yellow", Brightness="0.5", ArgbValue="255,255,255,000" },
                                       new colorAttribute {Name="Violet", Brightness="0.7215686", ArgbValue="255,238,130,238" },
                                       new colorAttribute {Name="Magenta", Brightness="0.5", ArgbValue="255,255,000,255" } };

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SortByArgbValue_Click(object sender, EventArgs e)
        {

            textBox5.Text = "";
            
            colorattribute.SetColorSortMethod(new SortByArgbValue());
            colorattribute.Sort(colorList);
            textBox5.Text = "Sorted query3 by Argb Value \r\n";
            textBox5.Text = textBox5.Text + Global.gv_DisplayData;
        }

        private void btn_SortByBrightness_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";

            colorattribute.SetColorSortMethod(new SortByBrightness());
            colorattribute.Sort(colorList);
            textBox5.Text = "Sorted query2 by Brightness \r\n";
            textBox5.Text = textBox5.Text + Global.gv_DisplayData;
        }

        private void btn_SorByName_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";

            colorattribute.SetColorSortMethod(new SortByName());
            colorattribute.Sort(colorList);
            textBox5.Text = "Sorted query1 by Name \r\n";
            textBox5.Text = textBox5.Text + Global.gv_DisplayData;
        }

    }

}
