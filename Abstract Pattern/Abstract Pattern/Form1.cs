﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Pattern
{
    public partial class Form1 : Form
    {
        PokemonFactory firstGen = new FirstGenerationFactory();
        PokemonFactory secondGen = new SecondGenerationFactory();

        public Form1()
        {
            InitializeComponent();
            tb_Outcome.Text = "A wild pokemon has appeared!";
        }

        private void btn_Battle_Click(object sender, EventArgs e)
        {
            if (rb_Charamander.Checked == true)
            {
                PokemonWorld world = new PokemonWorld(firstGen);
                tb_Outcome.Text = world.Battle();
            }

            else if (rb_Cindaquill.Checked == true)
            {
                PokemonWorld world = new PokemonWorld(secondGen);
                tb_Outcome.Text = world.Battle();
            }

        }
    }
}