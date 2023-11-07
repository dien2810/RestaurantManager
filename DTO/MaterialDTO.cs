using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class MaterialDTO
    {
        public MaterialDTO(int ID, string Name, string Unit, int Quantity, int ManagerID) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Unit = Unit;
            this.Quantity = Quantity;
            this.ManagerID = ManagerID;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Unit {  get; set; }
        public int Quantity {  get; set; }
        public int ManagerID { get; set; }
    }
}
