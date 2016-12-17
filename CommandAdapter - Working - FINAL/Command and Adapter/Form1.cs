using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Command_and_Adapter
{
    public partial class Form1 : Form
    {
        private int undoCount = 0;
        private int redoCount = 0;
        private int submitCount = 0;

        // Code for Command pattern
        // Uncomment User and comment out AdapterUser when running the Command pattern
        //private User user = new User();

        // Code for Command/Adapter patterns combined
        // Comment out User and uncomment AdapterUser when running the Command/Adapter combined pattern
        public AdapterUser adaptee = new AdapterUser();

        public Form1()
        {
            InitializeComponent();

        }

        private void btn_OperatorPlus_Click(object sender, EventArgs e)
        {
            tb_Operator.Text = "+";
        }

        private void btn_OperatorMinus_Click(object sender, EventArgs e)
        {
            tb_Operator.Text = "-";
        }

        private void btn_OperatorMultiply_Click(object sender, EventArgs e)
        {
            tb_Operator.Text = "*";
        }

        private void btn_OperatorDivide_Click(object sender, EventArgs e)
        {
            tb_Operator.Text = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "0";
        }

        private void btn_Value1_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "1";
        }

        private void btn_Value2_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "2";
        }

        private void btn_Value3_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "3";
        }

        private void btn_Value4_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "4";
        }

        private void btn_Value5_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "5";
        }

        private void btn_Value6_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "6";
        }

        private void btn_Value7_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "7";
        }

        private void btn_Value8_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "8";
        }

        private void btn_Value9_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + "9";
        }

        private void btn_ValueDecimalPoint_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = tb_NewValue.Text + ".";
        }

        private void btn_ValueDelete_Click(object sender, EventArgs e)
        {
            tb_NewValue.Text = "";
        }

        private void btn_SubmitChange_Click(object sender, EventArgs e)
        {
            if (tb_NewValue.Text != "")
            {
                if (tb_Operator.Text != "")
                {
                    // Call for Command pattern code
                    //tb_Display.Text = user.Compute(Convert.ToChar(tb_Operator.Text), Convert.ToInt16(tb_NewValue.Text));

                    // Call for Command/Adapter patterns combined code
                    tb_Display.Text = adaptee.AdapterCompute(Convert.ToChar(tb_Operator.Text), Convert.ToInt16(tb_NewValue.Text));
                    tb_NewValue.Text = "";
                    tb_Operator.Text = "";
                    submitCount = submitCount+1;
                }
                else {
                    MessageBox.Show("Operator must be selected before submitting request.");
                }
            }
            else
            {
                MessageBox.Show("Value must be entered before submitting request.");
            }
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            if(undoCount > 0)
            {
                // Call for Command pattern code
                //tb_Display.Text = user.Redo(1);

                // Call for Command/Adapter patterns combined code
                tb_Display.Text = adaptee.AdapterRedo();

                redoCount = redoCount+1;
            }
            else
            {
                MessageBox.Show("There is nothing to Redo.");
            }
        }

        private void btn_Undo_Click_1(object sender, EventArgs e)
        {
            if(submitCount > 0)
            {
                // Call for Command pattern code
                //tb_Display.Text = user.Undo(1);

                // Call for Command/Adapter patterns combined code
                tb_Display.Text = adaptee.AdapterUndo();
                undoCount = undoCount+1;
            }
            else
            {
                MessageBox.Show("There is nothing to Undo.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Call for Command pattern code
            //tb_Display.Text = user.Compute('+', 0);

            // Call for Command/Adapter patterns combined code
            tb_Display.Text = adaptee.AdapterCompute('+', 0);
        }
    }
}
