using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class EmployeeDTO
    {
        public EmployeeDTO(int ID, string FirstName, string LastName, string Address, DateTime BirthDate, string Gender, string PhoneNumber, DateTime StartingDate) 
        { 
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.StartingDate = StartingDate;
        }
        public int ID { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime StartingDate { get; set; }
    }
}
