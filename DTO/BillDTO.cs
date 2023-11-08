using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class BillDTO
    {
        public BillDTO(int CustomerID, int EmployeeID, int TableID) 
        {
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            this.TableID = TableID;
        }

        public int CustomerID {  get; set; }
        public int EmployeeID { get; set; }
        public int TableID { get; set; }

        public int ID { get; set; }
        public float Value { get; set;}
        public DateTime Time { get; set;}
        public string State { get; set;}

    }
}
