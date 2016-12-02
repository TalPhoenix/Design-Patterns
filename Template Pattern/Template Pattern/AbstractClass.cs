using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Template_Pattern
{
    public abstract class AbstractClass
    {
        protected string ConnectionPath;
        protected DataSet dataset;

        public virtual void Connect()
        {
            ConnectionPath = "provider=Microsoft.JET.OLEDB.4.0; " + "data source=C:\\Temp\\Northwind.mdb";
        }

        public abstract void Select();

        public abstract string Process();

        public virtual void Disconnect()
        {
            ConnectionPath = "";
        }

        public string Run()
        {
            string _colorOutput;

            Connect();
            Select();
            _colorOutput = Process();
            Disconnect();

            return _colorOutput;
        }
    }
}
