using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State_Example
{

    // The 'Context' class
    public class StudentGrades
    {
        private State _state;
        private string _student;
        private string _quiz;
        private string _midterm;
        private string _final;


        // Constructor
        public StudentGrades(string student)
        {
            // New grades are 'B' by default
            this._student = student;
            this._state = new BStudentState(0.0, this);
        }

        // Properties
        public double RawGradeScore
        {
            get { return _state.RawGradeScore; }
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Quiz
        {
            get { return _quiz; }
            set { _quiz = value; }
        }

        public string Midterm
        {
            get { return _midterm; }
            set { _midterm = value; }
        }

        public string Final
        {
            get { return _final; }
            set { _final = value; }
        }

        public string PostGrade(double amount, string assignment)
        {   
            _state.PostGrade(amount, assignment);
            return "PostGrade: " + amount.ToString() + "\r\n" + " Assignment: " + assignment.ToString() + "\r\n" + " RawGradeScore = " + this.RawGradeScore + "\r\n" + " GradeStatus = " + this.State.GetType().Name + "\r\n";
        }
    }
}
