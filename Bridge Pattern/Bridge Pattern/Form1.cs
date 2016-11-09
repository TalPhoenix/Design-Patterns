using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge_Pattern
{
    public partial class Form1 : Form
    {

        RefinedAbstraction movies = new RefinedAbstraction("Fantasy");

        public Form1()
        {
            InitializeComponent();

            movies.Genre = new ConcreteImplementor();
        }

        private void btn_AddMovie_Click(object sender, EventArgs e)
        {
            movies.Add(tb_movie.Text);
            movies.Last();
            tb_movie.Text = movies.Show();
        }

        private void btn_NextMovie_Click(object sender, EventArgs e)
        {
            movies.Next();
            tb_movie.Text = movies.Show();
        }

        private void btn_PreviousMovie_Click(object sender, EventArgs e)
        {
            movies.Prior();
            tb_movie.Text = movies.Show();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            tb_list.Text = movies.ShowAll();
        }

        private void btn_CurrentMovie_Click(object sender, EventArgs e)
        {
            tb_movie.Text =  movies.Show();
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            movies.First();
            tb_movie.Text = movies.Show();
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            movies.Last();
            tb_movie.Text = movies.Show();
        }
    }
}
