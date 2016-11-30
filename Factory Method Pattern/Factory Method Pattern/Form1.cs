using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Method_Pattern
{
    public partial class Form1 : Form
    {
        Game[] games = new Game[3];

        public Form1()
        {
            InitializeComponent();

            games[0] = new RPG();
            games[1] = new Strategy();
            games[2] = new Platform();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {

            foreach (Game game in games)
            {
                tb_list.Text = tb_list.Text + game.GetType().Name + "\r\n";
                foreach (GameElements gameelement in game.Games)
                {
                    tb_list.Text = tb_list.Text + " - " + gameelement.GetType().Name + "\r\n";
                }
                tb_list.Text = tb_list.Text + "\r\n\r\n";
            }
        }
    }
}
