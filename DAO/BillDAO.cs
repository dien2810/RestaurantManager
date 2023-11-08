using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.DAO
{
    internal class BillDAO
    {
        string query;
        public int Insert(BillDTO Bill, ref string ErrMsg)
        {
            query = "EXEC ThemHoaDon @MaKH @MaNV @MaBan"; 
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                Bill.ID, Bill.Value, Bill.Time, Bill.State
            });
        }
        public int Update(BillDTO Bill, ref string ErrMsg)
        {
            query = "EXEC SuaHoaDon @MaKH @TrangThai @TriGiaHD @MaBan";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                Bill.ID, Bill.Value, Bill.Time, Bill.State
            });
        }
        public int Delete(string BillID, ref string ErrMsg)
        {
            query = "EXEC XoaHoaDon @MaHD";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {BillID});
        }

        public DataTable GetAll(ref string ErrMsg) 
        {
            query = "SELECT * FROM HoaDon";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
    }
}
