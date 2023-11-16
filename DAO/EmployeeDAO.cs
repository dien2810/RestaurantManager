using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.DTO;

namespace RestaurantManager.DAO
{
    internal class EmployeeDAO
    {
        private string query;
        
        public int Insert(EmployeeDTO Employee, ref string ErrMsg)
        {
            query = "EXEC PROC_ThemNhanVien @HoNV , @TenNV , @NgaySinh , @GioiTinh , @DiaChi , @SDT , @NgayTD , @MaNQL , @MaCV";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]
            {
                Employee.LastName, Employee.FirstName, Employee.BirthDate, Employee.Gender, 
                Employee.Address, Employee.PhoneNumber, Employee.StartingDate, 1 ,Employee.JobID
            });
        }
        public int Update(EmployeeDTO Employee, ref string ErrMsg)
        {
            query = "EXEC EXEC PROC_ThemNhanVien @MaNV , @HoNV , @TenNV , @NgaySinh , @GioiTinh , @DiaChi , @SDT , @NgayTD , @MaNQL , @MaCV ";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]
            {
                Employee.ID, Employee.FirstName, Employee.FirstName, Employee.BirthDate, Employee.Gender, 
                Employee.Address, Employee.PhoneNumber, Employee.StartingDate, 1, Employee.JobID
            });
        }
        public int Delete(int EmployeeID, ref string ErrMsg)
        {
            query = "EXEC PROC_XoaNhanVien @MaNV";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]{ EmployeeID });
        }

        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM V_ThongTinNhanVien";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }

        public DataTable SearchByName(string Name, ref string ErrMsg) 
        {
            query = "FUNC_TimKiemNhanVien @HoNV , @TenNV , @GioiTinh , @SDT , @MaNQL , @TenCV";
            return DataProvider.ExecuteQuery(query, ref ErrMsg, new object[]
            {
                null, Name, null, null, null
            });
        }
    }
}
