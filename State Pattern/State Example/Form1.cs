using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State_Example
{
    public partial class Form1 : Form
    {
        StudentGrades grade = new StudentGrades("Jim Johnson");

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GradeBookEntry_Click(object sender, EventArgs e)
        {
            if (cb_Assignments.Text == "Quiz" )
            {
                grade.Quiz = "Y";
                grade.Midterm = "N";
                grade.Final = "N";
            }
            else if (cb_Assignments.Text == "Midterm")
            {
                grade.Quiz = "N";
                grade.Midterm = "Y";
                grade.Final = "N";
            }
            else if (cb_Assignments.Text == "Final")
            {
                grade.Quiz = "N";
                grade.Midterm = "N";
                grade.Final = "Y";
            }
            tb_GradeBook.Text = tb_GradeBook.Text + " " + grade.PostGrade(Convert.ToDouble(tb_Grade.Text), cb_Assignments.Text) + "\r\n";
        }
    }
}
