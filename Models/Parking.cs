namespace ParkingSystem.Models
{
    public class Parking : BaseModel
    {
        public int PlaceId { get; set; }
        public DateTime ParkingDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string VehicleNumber { get; set; }
    }
}
