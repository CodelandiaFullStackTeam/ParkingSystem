using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public abstract class BaseModel
    {
        public int ID { get; set; }
        public int Deleted { get; set; }
    }
}
