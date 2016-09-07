using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator_Pattern
{
    public partial class Form1 : Form
    {
        Aggregate agg = new ConcreteAggregate();
        Iterator iterator;
        IteratorTwo iteratortwo;

        public Form1()
        {
            InitializeComponent();
            PrepareAggWithIter();
        }

        private void PrepareAggWithIter()
        {
           agg.Elements.Add(1);
           agg.Elements.Add(2);
           agg.Elements.Add(3);
           agg.Elements.Add(4);
           agg.Elements.Add(5);
           agg.Elements.Add(6);
           agg.Elements.Add(7);
           iterator = agg.createIterator();
           iteratortwo = agg.createIteratorTwo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            iterator.First();
            while (!iterator.IsDone())
            {
                listBox1.Items.Add(iterator.CurrentItem());
                iterator.Next();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iteratortwo.First();
            while (!iteratortwo.IsDone())
            {
                listBox1.Items.Add(iteratortwo.CurrentItem());
                iteratortwo.Next();
            }
        }
    }
}
