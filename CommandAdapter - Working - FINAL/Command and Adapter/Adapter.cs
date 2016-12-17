using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_and_Adapter
{
    public class AdapterUser // Used when the Command/Adapter pattern is enabled
    {
        User user = new User();

        public string AdapterUndo()
        {
            //User _user = new User();
            return user.Undo(Convert.ToInt16(1));
        }
        public string AdapterRedo()
        {
            //User _user = new User();
            return user.Redo(Convert.ToInt16(1));
        }
        public string AdapterCompute(char @operator, short operand)
        {
            //User _user = new User();
            return user.Compute(@operator, operand);
        }
    }
}
