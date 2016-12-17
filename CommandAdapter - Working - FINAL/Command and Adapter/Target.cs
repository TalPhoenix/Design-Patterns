using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_and_Adapter
{
    public interface ITarget
    {
        // Used when the Command/Adapter pattern is enabled
        // Interface for New Client calls
        string AdapterRedo();
        string AdapterUndo();
        string AdapterCompute(char @operator, short operand);
    }
}
