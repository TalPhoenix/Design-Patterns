using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPattern
{
    public partial class Form1 : Form
    {
        Proxy proxy = new Proxy();
        ColorDialog MyDialog = new ColorDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ShowDialog_Click(object sender, EventArgs e)
        {
            if (MyDialog.ShowDialog() == DialogResult.OK)
                pnl_MyColor.BackColor = proxy.GetCol(MyDialog);
            tb_1.Text = "This is the Alpha Component of your color: " + proxy.GetA(MyDialog);
            tb_2.Text = "This is the Red Component of your color: " + proxy.GetR(MyDialog);
            tb_3.Text = "This is the Blue Component of your color: " + proxy.GetG(MyDialog);
            tb_4.Text = "This is the Green Component of your color: " + proxy.GetB(MyDialog);
        }
    }
}
