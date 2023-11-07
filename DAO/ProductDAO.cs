using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class ProductDAO
    {
        string query;

        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM SanPham";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
    }
}
