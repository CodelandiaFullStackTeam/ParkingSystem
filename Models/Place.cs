namespace ParkingSystem.Models
{
    public class Place : BaseModel
    {
        public int SectionId { get; set; }
        public int PlaceNumber { get; set; }
        public bool IsLocked { get; set; }
    }
}
