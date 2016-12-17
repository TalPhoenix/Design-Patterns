using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_and_Adapter
{
    public class User // Used as the Adaptee class when Command/Adapter pattern is enabled
    {
        // Initializers
        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();
        private int _current = 0;

        public string Redo(int levels)
        {
            string returnValue = "";
            // Debugging Code
            //Console.WriteLine("\n---- Redo {0} levels ", levels);

            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current <= _commands.Count - 1)
                {
                    Command command = _commands[_current++];
                    returnValue = command.Execute();
                }
            }
            return returnValue;
        }

        public string Undo(int levels)
        {
            string returnValue = "";
            // Debugging Code
            //Console.WriteLine("\n---- Undo {0} levels ", levels);

            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Command command = _commands[--_current] as Command;
                    returnValue = command.UnExecute();
                }
            }
            return returnValue;
        }

        public string Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            string returnValue = "";
            Command command = new CalculatorCommand(
              _calculator, @operator, operand);
            returnValue = command.Execute();

            // Add command to undo list
            _commands.Add(command);
            _current++;
            return returnValue;
        }
    }
}
