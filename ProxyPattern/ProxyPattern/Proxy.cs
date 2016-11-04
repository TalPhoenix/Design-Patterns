using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPattern
{
    public class Proxy : Subject
    {
        private RealSubject _strftn = new RealSubject();

        public System.Drawing.Color GetCol(System.Windows.Forms.ColorDialog ColDig)
        {
            return _strftn.GetCol(ColDig);
        }
        public string GetA(System.Windows.Forms.ColorDialog ColDig)
        {
            return _strftn.GetA(ColDig);
        }
        public string GetR(System.Windows.Forms.ColorDialog ColDig)
        {
            return _strftn.GetR(ColDig);
        }
        public string GetG(System.Windows.Forms.ColorDialog ColDig)
        {
            return _strftn.GetG(ColDig);
        }
        public string GetB(System.Windows.Forms.ColorDialog ColDig)
        {
            return _strftn.GetB(ColDig);
        }

    }
}
