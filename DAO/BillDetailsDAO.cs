using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class BillDetailsDAO
    {
        string query;
        public int Insert(BillDetailsDTO BillDe, ref string ErrMsg)
        {
            query = "";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                BillDe.ProductID, BillDe.BillID, BillDe.Quantity
            });
        }
        public int Update(BillDetailsDTO BillDe, ref string ErrMsg)
        {
            query = "";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                BillDe.ProductID, BillDe.BillID, BillDe.Quantity
            });
        }

        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM ChiTietHD";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
    }
}
