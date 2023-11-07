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
            query = "EXEC [Tên proc hay func] ";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]
            {
                Employee.ID, Employee.FirstName, Employee.FirstName, Employee.Address, Employee.BirthDate, Employee.Gender, Employee.PhoneNumber, Employee.StartingDate
            });
        }
        public int Update(EmployeeDTO Employee, ref string ErrMsg)
        {
            query = "EXEC [Tên proc hay func] ";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]
            {
                Employee.ID, Employee.FirstName, Employee.FirstName, Employee.Address, Employee.BirthDate, Employee.Gender, Employee.PhoneNumber, Employee.StartingDate
            });
        }
        public int Delete(string EmployeeID, ref string ErrMsg)
        {
            query = "EXEC [Tên proc hay func] ";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]{EmployeeID});
        }

        // get the Employee list
        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM V_ThongTinNhanVien";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }

        // search Employee
        public DataTable SearchByName(string Name, ref string ErrMsg) 
        {
            return null;
        }
        public DataTable SearchByID(string ID, ref string ErrMsg)
        {
            query = "";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
    }
}
