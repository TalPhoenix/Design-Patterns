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
    public class ColorNames : AbstractClass
    {
        public override void Select()
        {
            string sql = "select Color from Colors";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, ConnectionPath);
            dataset = new DataSet();
            dataAdapter.Fill(dataset, "Colors");
        }
        public override string Process()
        {
            string colorOutput = "";
            colorOutput = "Colors ----- \r\n";
            DataTable dataTable = dataset.Tables["Colors"];
            foreach (DataRow row in dataTable.Rows)
            {
                colorOutput = colorOutput + " - " + row["Color"] + "\r\n";
            }
            return colorOutput;
        }
    }
}
