using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class CustomerDAO
    {
        string query;
        public int Insert(CustomerDTO Customer, ref string ErrMsg)
        {
            query = "";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                Customer.ID, Customer.Name, Customer.PhoneNumber, Customer.Address, Customer.Gender//, Customer.Points
            });
        }
        public int Update(CustomerDTO Customer, ref string ErrMsg)
        {
            query = "";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                Customer.ID, Customer.Name, Customer.PhoneNumber, Customer.Address, Customer.Gender, Customer.Points
            });
        }
        public int Delete(string CustomerID, ref string ErrMsg)
        {
            this.query = "";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] { CustomerID });
        }

        // search Customer by Phone number
        public DataTable SearchByPhoneNumber(string PhoneNumber, ref string ErrMsg)
        {
            query = "";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
    }
}