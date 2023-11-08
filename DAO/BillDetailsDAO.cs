﻿using RestaurantManager.DTO;
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
        public int Insert(int BillID, string ProductName, int Quantity, ref string ErrMsg)
        {
            query = "EXEC ThemChiTietHD @MaHD , @TenSP , @SoLuong";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                BillID, ProductName, Quantity
            });
        }
    }
}
