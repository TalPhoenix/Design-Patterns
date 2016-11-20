using CharacterDesigner.ConcreteComponents;
using CharacterDesigner.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterDesigner
{
    public partial class CharacterDesignForm : Form
    {
        public CharacterDesignForm()
        {
            InitializeComponent();
        }

        private void CharacterDesignForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string displayText = "";

            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            { 
                button1.Enabled = true;
            }
            else {
                button1.Enabled = false;
            }
            textBox1.Text = displayText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string displayText = textBox1.Text;
            CostumeCharacter baseCharacter = new CostumeCharacter(comboBox1.Text);

            String s = comboBox2.Text;
            String searchString = ":";
            int startIndex = s.IndexOf(searchString) + 1;
            int endIndex = s.Length - startIndex;
            String substring = s.Substring(startIndex, endIndex);
            double selectedPrice = Convert.ToDouble(substring);
            string selectedTransaction = s.Substring(0, startIndex - 1);
            String selectedSize = comboBox3.Text;

            // Pants Base
            CostumeBase basecharacter = new CostumeBase(selectedTransaction);
            displayText = "Selected Character: " + baseCharacter.GetCharacter(comboBox1.Text).ToString() + "\r\n";
            displayText = displayText + "Purchase/Rent: " + basecharacter.GetName(selectedTransaction).ToString() + "\r\n";
            displayText = displayText + "Selected Size: " + basecharacter.GetSize(selectedSize).ToString() + "\r\n";
            displayText = displayText + "Total Price: $" + basecharacter.GetPrice(selectedPrice).ToString() + "\r\n\r\n\r\n";

            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                // Mask Decorator Concrete
                CharacterMaskDecorator maskCharacter1 = new CharacterMaskDecorator(basecharacter);
                displayText = displayText + "Selected Character: " + baseCharacter.GetCharacter(comboBox1.Text).ToString() + "\r\n";
                displayText = displayText + "Purchase/Rent: " + maskCharacter1.GetName(selectedTransaction).ToString() + "\r\n";
                displayText = displayText + "Selected Size: " + maskCharacter1.GetSize(selectedSize).ToString() + "\r\n";
                displayText = displayText + "Total Price: $" + maskCharacter1.GetPrice(selectedPrice).ToString() + "\r\n\r\n\r\n";

                // Shoes Decorator Concrete
                CharacterShoesDecorator shoesCharacter1 = new CharacterShoesDecorator(maskCharacter1);
                displayText = displayText + "Selected Character: " + baseCharacter.GetCharacter(comboBox1.Text).ToString() + "\r\n";
                displayText = displayText + "Purchase/Rent: " + shoesCharacter1.GetName(selectedTransaction).ToString() + "\r\n";
                displayText = displayText + "Selected Size: " + shoesCharacter1.GetSize(selectedSize).ToString() + "\r\n";
                displayText = displayText + "Total Price: $" + shoesCharacter1.GetPrice(selectedPrice).ToString() + "\r\n\r\n\r\n";
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                // Mask Decorator Concrete
                CharacterMaskDecorator maskCharacter = new CharacterMaskDecorator(basecharacter);
                displayText = displayText + "Selected Character: " + baseCharacter.GetCharacter(comboBox1.Text).ToString() + "\r\n";
                displayText = displayText + "Purchase/Rent: " + maskCharacter.GetName(selectedTransaction).ToString() + "\r\n";
                displayText = displayText + "Selected Size: " + maskCharacter.GetSize(selectedSize).ToString() + "\r\n";
                displayText = displayText + "Total Price: $" + maskCharacter.GetPrice(selectedPrice).ToString() + "\r\n\r\n\r\n";
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                // Shoes Decorator Concrete
                CharacterShoesDecorator shoesCharacter = new CharacterShoesDecorator(basecharacter);
                displayText = displayText + "Selected Character: " + baseCharacter.GetCharacter(comboBox1.Text).ToString() + "\r\n";
                displayText = displayText + "Purchase/Rent: " + shoesCharacter.GetName(selectedTransaction).ToString() + "\r\n";
                displayText = displayText + "Selected Size: " + shoesCharacter.GetSize(selectedSize).ToString() + "\r\n";
                displayText = displayText + "Total Price: $" + shoesCharacter.GetPrice(selectedPrice).ToString() + "\r\n\r\n\r\n";
            }

            textBox1.Text = displayText;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string displayText = "";

            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                button1.Enabled = true;
            }
            else {
                button1.Enabled = false;
            }
            textBox1.Text = displayText;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string displayText = "";

            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                button1.Enabled = true;
            }
            else {
                button1.Enabled = false;
            }
            textBox1.Text = displayText;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            string displayText = "";

            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                button1.Enabled = true;
            }
            else {
                button1.Enabled = false;
            }
            textBox1.Text = displayText;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string displayText = "";

            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                button1.Enabled = true;
            }
            else {
                button1.Enabled = false;
            }
            textBox1.Text = displayText;
        }
    }
}
