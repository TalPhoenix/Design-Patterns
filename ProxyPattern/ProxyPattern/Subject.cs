using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface Subject
    {
        System.Drawing.Color GetCol(System.Windows.Forms.ColorDialog ColDig);
        string GetA(System.Windows.Forms.ColorDialog ColDig);
        string GetR(System.Windows.Forms.ColorDialog ColDig);
        string GetG(System.Windows.Forms.ColorDialog ColDig);
        string GetB(System.Windows.Forms.ColorDialog ColDig);
    }
}
