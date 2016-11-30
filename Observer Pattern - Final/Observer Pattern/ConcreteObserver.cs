using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class ConcreteObserver : Observer //Concrete Observer
    {
        private string _name;
        private Sender _sender;

        // Constructor
        public ConcreteObserver(string name)
        {
            this._name = name;
        }

        public void Update(Sender sender)
        {
            System.Windows.Forms.MessageBox.Show("Observer has been notified: " + _name );
            Console.WriteLine("Notified {0} {1} {2} {3} " , _name, sender._mailTo, sender._subject, sender._message);
            //this will be a message box and will show name of observer then sender.Message and will pop up after message has been sent
        }

        // Gets or sets the stock
        public Sender Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }
    }
}
