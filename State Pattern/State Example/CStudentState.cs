using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Example
{
    // A 'ConcreteState' class
    class CStudentState : State
    {
        // Constructor
        public CStudentState(State state)
        {
            this.rawgradescore = state.RawGradeScore;
            this.grade = state.Grades;
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
                lowerLimit = 1.01;
                upperLimit = 2.0;
            }
            else if (grade.Midterm == "Y")
            {
                lowerLimit = 2.01;
                upperLimit = 4.0;
            }
            else if (grade.Final == "Y")
            {
                lowerLimit = 3.01;
                upperLimit = 6.0;
            }


            if (rawgradescore > upperLimit)
            {
                grade.State = new BStudentState(this);
            }
            return grade.State.ToString();
        }
    }
}
