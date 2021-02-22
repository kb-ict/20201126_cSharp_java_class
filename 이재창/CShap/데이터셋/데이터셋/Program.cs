using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 데이터셋
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            DataColumn dcName = new DataColumn();
            dcName.ColumnName = "이름";
            dcName.DataType = typeof(string);
            DataColumn dcAge = new DataColumn("나이", typeof(int));

            dt.Columns.Add(dcName);
            dt.Columns.Add(dcAge);

            DataRow row = dt.NewRow();
            row[dcName] = "가나다";
            row[dcAge] = 20;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[dcName] = "라마바";
            row[dcAge] = 25;
            dt.Rows.Add(row);

            ds.Tables.Add(dt);
        }
    }
}
