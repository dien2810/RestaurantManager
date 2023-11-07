using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class BillDetailsDTO
    {
        private int ProductID;
        private int BillID;
        private int Quantity;

        public BillDetailsDTO(int ProductID, int BillID, int Quantity)
        {
            this.ProductID = ProductID;
            this.BillID = BillID;
            this.Quantity = Quantity;
        }
    }
}
