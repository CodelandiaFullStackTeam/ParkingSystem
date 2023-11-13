using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Models.ViewModels
{
    public class SectionVM:BaseModel
    {
        private string FloorChar = "F";
        public int FloorNumber { get; set; }
        public int Capacity { get; set; }
        public string SectionCode { get; set; }
        public string FloorCode => FloorChar + FloorNumber;
    }
}
