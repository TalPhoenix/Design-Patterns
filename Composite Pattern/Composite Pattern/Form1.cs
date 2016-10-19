using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite_Pattern
{
    
    public partial class Form1 : Form
    {

        Composite ShoppingCart = new Composite("Shopping Cart");
        Composite WatercolorKit = new Composite("Watercolor Kit");
        Composite AcrylicKit = new Composite("Acrylic Kit");
        Composite MixedMediaKit = new Composite("Mixed Media Kit");

        public Form1()
        {
            InitializeComponent();

            WatercolorKit.Add(new Leaf("Watercolor Paint Set||14.53"));
            WatercolorKit.Add(new Leaf("Pentel Aquash Set||13.58"));
            WatercolorKit.Add(new Leaf("Canson Watercolor Paper Pad||9.49"));

            AcrylicKit.Add(new Leaf("Liquitex Acrylic Paint||35.84"));
            AcrylicKit.Add(new Leaf("Paint Brush Set||24.17"));
            AcrylicKit.Add(new Leaf("Canvas Pack||17.05"));
            AcrylicKit.Add(new Leaf("Paint Palette||9.65"));

            MixedMediaKit.Add(new Leaf("Watercolor Paint Set||14.53"));
            MixedMediaKit.Add(new Leaf("Pentel Aquash Set||13.58"));
            MixedMediaKit.Add(new Leaf("Canson Watercolor Paper Pad||9.49"));
            MixedMediaKit.Add(new Leaf("Liquitex Acrylic Paint||35.84"));
            MixedMediaKit.Add(new Leaf("Paint Brush Set||24.17"));
            MixedMediaKit.Add(new Leaf("Canvas Pack||17.05"));
            MixedMediaKit.Add(new Leaf("Paint Palette||9.65"));

        }

        private void updateShoppingCartDisplay()
        {
            tb_DisplayData.Text = "";
            ShoppingCart.Display(0);
            tb_DisplayData.Text = Global.gv_DisplayData + "\r\n" + " Total Price: " + Global.gv_TotalPrice.ToString();
        }

        private void btn_Watercolor_Click(object sender, EventArgs e)
        {
            Global.gv_DisplayData = Global.gv_DisplayData + "Watercolor Kit \r\n";
            ShoppingCart.Add(WatercolorKit);
            updateShoppingCartDisplay();
        }

        private void btn_Acrylic_Click(object sender, EventArgs e)
        {
            Global.gv_DisplayData = Global.gv_DisplayData + "Acrylic Kit \r\n";
            ShoppingCart.Add(AcrylicKit);
            updateShoppingCartDisplay();
        }

        private void btn_MixedMedia_Click(object sender, EventArgs e)
        {
            Global.gv_DisplayData = Global.gv_DisplayData + "Mixed Media Kit \r\n";
            ShoppingCart.Add(MixedMediaKit);
            updateShoppingCartDisplay();
        }


        private void acrylicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.gv_DisplayData = Global.gv_DisplayData + "Acrylic Kit \r\n";
            ShoppingCart.Add(AcrylicKit);
            updateShoppingCartDisplay();
        }

        private void waterColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.gv_DisplayData = Global.gv_DisplayData + "Watercolor Kit \r\n";
            ShoppingCart.Add(WatercolorKit);
            updateShoppingCartDisplay();
        }


        private void mixedmediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.gv_DisplayData = Global.gv_DisplayData + "Mixed Media Kit \r\n";
            ShoppingCart.Add(MixedMediaKit);
            updateShoppingCartDisplay();
        }
    }
}
