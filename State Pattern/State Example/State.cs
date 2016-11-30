using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Example
{
    // The 'State' abstract class
    public abstract class State
    {
        protected StudentGrades grade;
        protected double rawgradescore;

        protected double bonuspoints;
        protected double lowerLimit;
        protected double upperLimit;


        // Properties
        public StudentGrades Grades
        {
            get { return grade; }
            set { grade = value; }
        }

        public double RawGradeScore
        {
            get { return rawgradescore; }
            set { rawgradescore = value; }
        }

        public abstract string PostGrade(double amount, string assignment);
    }
}
