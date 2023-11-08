using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class BillDTO
    {
        public BillDTO(float Value, DateTime Time, string State) 
        {
            this.Value = Value;
            this.Time = Time;
            this.State = State;
        }
        public int ID { get; set; }
        public float Value { get; set;}
        public DateTime Time { get; set;}
        public string State { get; set;}
    }
}
