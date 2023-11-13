using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class Floor:BaseModel
    {
        private string FloorNameChar = "F";
        public int FloorNumber { get; set; }
        public string FloorCode => FloorNameChar + FloorNumber;
        public int Capacity { get; set; }


        public Floor()
        {
            
        }

        public Floor(int floorNumber,int capacity)
        {
            FloorNumber = floorNumber;
            Capacity = capacity;
        }

    }
}
