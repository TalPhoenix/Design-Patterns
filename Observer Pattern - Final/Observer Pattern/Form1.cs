using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ConcreteSender cs = new ConcreteSender("", "", "");
            cs.Attach(new ConcreteObserver("Class Professor"));
            cs.Attach(new ConcreteObserver("Class Assistant Professor"));

            cs.mailTo = tb_MailTo.Text;
            cs.subject = tb_Subject.Text;
            cs.message = tb_Message.Text;

            MailUtilities.Gmail.SendGmail(tb_SenderAccount.Text, tb_AccountPassword.Text, tb_SenderEmailAddress.Text,  "", true, cs.mailTo, cs.subject, cs.message);
        }

        private void tb_AccountPassword_Enter(object sender, EventArgs e)
        {
            // Set to no text.
            tb_AccountPassword.Text = "";
            // The password character is an asterisk.
            tb_AccountPassword.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            tb_AccountPassword.MaxLength = 14;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setup default assignment reminder message
            tb_SenderAccount.Text = "tcell44@gmail.com";
            tb_SenderEmailAddress.Text = "tcell44@gmail.com";
            tb_Subject.Text = "Reminder Message: Your Next Assignment";
            tb_Message.Text = "To: " + tb_MailTo.Text + "\r\n\r\nYour assignment is due in 2 days. \r\n\r\nThank You\r\nYou Know Who";
        }

        private void tb_MailTo_TextChanged(object sender, EventArgs e)
        {
            tb_Message.Text = "To: " + tb_MailTo.Text + "\r\n\r\nYour assignment is due in 2 days. \r\n\r\nThank You\r\nYou Know Who";
        }
    }
}
