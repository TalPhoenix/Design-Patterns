using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Template_Pattern
{
    public class ARGBValues : AbstractClass
    {
        public override void Select()
        {
            string sql = "select ARGB from Colors";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, ConnectionPath);
            dataset = new DataSet();
            dataAdapter.Fill(dataset, "Colors");
        }
        public override string Process()
        {
            string colorOutput = "";
            colorOutput = "ARGB ----- \r\n";
            DataTable dataTable = dataset.Tables["Colors"];
            foreach (DataRow row in dataTable.Rows)
            {
                colorOutput = colorOutput + " - " + row["ARGB"] + "\r\n";
            }
            return colorOutput;
        }
    }
}
