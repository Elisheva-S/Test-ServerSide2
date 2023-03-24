using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Dal;
namespace Test_SQL_Data
{
    public class Tbl1Queries : Test_Base_SQL
    {
        public DataTable CreateTbl1()
        {
            string query = @"exec createTbl1";
            DataTable departmentsTable = new DataTable();
            Sql_Query.RunCommand(query, departmentsTable.Load);


            return departmentsTable;
        }
    }
}
