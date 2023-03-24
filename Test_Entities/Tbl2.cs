using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Model;
using Test_SQL_Data;

namespace Test_Entities
{
    public class Tbl2:Test_Base_Entity
    {
        Tbl2Queries query = new Tbl2Queries();
        public List<Tbl2_Model> CreateTbl2()
        {
            DataTable table = query.CreateTbl2();
            return ConvertDataTableToProductsList(table);
        }
        private List<Tbl2_Model> ConvertDataTableToProductsList(DataTable table)
        {
            List<Tbl2_Model> list = new List<Tbl2_Model>();
            foreach (DataRow dr in table.Rows)
            {
                var values = dr.ItemArray;
                var tbl2 = new Tbl2_Model()
                {
                    Num = values[0].ToString(),
                    KindOfPackage = values[1].ToString(),
                };
                list.Add(tbl2);
            }
            return list;
        }
    }
}
