using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Example
{
    // A 'ConcreteState' class
    class BStudentState : State
    {
        // Overloaded constructors
        public BStudentState(State state) :
          this(state.RawGradeScore, state.Grades)
        {
        }

        public BStudentState(double rawgradescore, StudentGrades grade)
        {
            this.rawgradescore = rawgradescore;
            this.grade = grade;
            Initialize();
        }

        private void Initialize()
        {
            if (grade.Quiz == "Y")
            {
                lowerLimit = 0;
                upperLimit = 0;
            }
            else if (grade.Midterm == "Y")
            {
                lowerLimit = 0;
                upperLimit = 0;
            }
            else if (grade.Final == "Y")
            {
                lowerLimit = 0;
                upperLimit = 0;
            }
        }

        public override string PostGrade(double amount, string assignment)
        {
            rawgradescore += amount;
            return StateChangeCheck();
        }

        private string StateChangeCheck()
        {
            if (grade.Quiz == "Y")
            {
                lowerLimit = 2.01;
                upperLimit = 3.0;
            }
            else if (grade.Midterm == "Y")
            {
                lowerLimit = 4.01;
                upperLimit = 6.0;
            }
            else if (grade.Final == "Y")
            {
                lowerLimit = 6.01;
                upperLimit = 9.0;
            }


            if (rawgradescore < lowerLimit)
            {
                grade.State = new CStudentState(this);
            }
            else if (   rawgradescore > upperLimit)
            {
                grade.State = new AStudentState(this);
            }
            return grade.State.ToString();
        }
    }
}
