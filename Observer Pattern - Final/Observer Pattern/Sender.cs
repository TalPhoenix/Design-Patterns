using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public abstract class Sender    //Abstract subject
    {  
        public string _message;
        public string _subject;
        public string _mailTo;
        private List<Observer> _observer = new List<Observer>();

        // Constructor
        public Sender(string message, string subject, string mailTo)
        {
            this._message = message;
            this._subject = subject;
            this._mailTo = mailTo;
        }

        public void Attach(Observer observer)
        {
            _observer.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observer.Remove(observer);
        }

        public void Notify()
        {          
            foreach (Observer observer in _observer)
            {
                observer.Update(this);
            }            
            Console.WriteLine("");
        }

        // Gets or sets the email mail to person
        public string mailTo
        {
            get { return _mailTo; }
            set
            {
                if (_mailTo != value)
                {
                    _mailTo = value;
                    Notify();
                }
            }

        }

        // Gets or sets the email subject
        public string subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        // Gets or sets the email message
        public string message
        {
            get { return _message; }
            set {_message = value; }
        }
    }
}
