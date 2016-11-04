using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealSubject : Subject
    {
        public System.Drawing.Color GetCol(System.Windows.Forms.ColorDialog ColDig)
        {
            return ColDig.Color;
        }
        public string GetA(System.Windows.Forms.ColorDialog ColDig)
        {
            return ColDig.Color.A.ToString();
        }
        public string GetR(System.Windows.Forms.ColorDialog ColDig)
        {
            return ColDig.Color.R.ToString();
        }
        public string GetG(System.Windows.Forms.ColorDialog ColDig)
        {
            return ColDig.Color.G.ToString();
        }
        public string GetB(System.Windows.Forms.ColorDialog ColDig)
        {
            return ColDig.Color.B.ToString();
        }

    }
}
