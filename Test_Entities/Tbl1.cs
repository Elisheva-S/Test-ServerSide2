using System.Data;
using Test_SQL_Data;
using Test_Model;
namespace Test_Entities
{
    public class Tbl1:Test_Base_Entity
    {
        Tbl1Queries query = new Tbl1Queries();
        public List<Tbl1_Model> CreateTbl1()
        {
            DataTable table = query.CreateTbl1();
            return ConvertDataTableToProductsList(table);
        }
        private List<Tbl1_Model> ConvertDataTableToProductsList(DataTable table)
        {
            List<Tbl1_Model> list = new List<Tbl1_Model>();
            foreach (DataRow dr in table.Rows)
            {
                var values = dr.ItemArray;
                var tbl1 = new Tbl1_Model()
                {
                    Num = values[0].ToString(),
                    KindOfPackage = values[1].ToString(),
                };
                list.Add(tbl1);
            }
            return list;
        }
    }
}