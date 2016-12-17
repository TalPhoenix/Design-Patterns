using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_and_Adapter
{
    public class CalculatorCommand : Command 
    {
        public char _operator;
        public int _operand;
        public Calculator _calculator;

    //    // Constructor
        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this._calculator = calculator;
            this._operator = @operator;
            this._operand = operand;
        }

    //    // Gets operator
        public char Operator
        {
            set { _operator = value; }
        }

    //    // Get operand
        public int Operand
        {
            set { _operand = value; }
        }

    //    // Execute new command
        public override string Execute()
        {
            return _calculator.Operation(_operator, _operand);
        }

    //    // Unexecute last command
        public override string UnExecute()
        {
           return _calculator.Operation(Undo(_operator), _operand);
        }

    //    // Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new
            ArgumentException("@operator");
            }
        }
    }
}
