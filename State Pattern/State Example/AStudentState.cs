using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Example
{

    // A 'ConcreteState' class
    class AStudentState : State
    {
        // Overloaded constructors
        public AStudentState(State state)
          : this(state.RawGradeScore, state.Grades)
        {
        }

        public AStudentState(double rawgradescore, StudentGrades grade)
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
                lowerLimit = 3.01;
                upperLimit = 4.0;
            }
            else if (grade.Midterm == "Y")
            {
                lowerLimit = 6.01;
                upperLimit = 8.0;
            }
            else if (grade.Final == "Y")
            {
                lowerLimit = 9.01;
                upperLimit = 12.0;
            }


            if (rawgradescore < lowerLimit/2)
            {
                grade.State = new CStudentState(this);
                
            }
            else if (rawgradescore < lowerLimit)
            {
                grade.State = new BStudentState(this);
                
            }
            return grade.State.ToString();
        }
    }
}
