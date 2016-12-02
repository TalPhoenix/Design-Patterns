using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_Pattern
{
    public partial class Form1 : Form
    {
        AbstractClass ColorPallet = new ColorNames();
        AbstractClass argbvalues = new ARGBValues();

        public Form1()
        {
            InitializeComponent();         
        }

        private void btn_DisplayColors_Click(object sender, EventArgs e)
        {
            tb_Colors.Text = ColorPallet.Run();
        }

        private void btn_ARGB_Click(object sender, EventArgs e)
        {
            tb_ARGB.Text = argbvalues.Run();
        }
    }
}
