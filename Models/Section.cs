namespace ParkingSystem.Models
{
    public class Section : BaseModel
    {
        public int FloorId { get; set; }
        public int Capacity { get; set; }
        public string SectionCode { get; set; }

        public Section()
        {
            
        }

        public Section(int floorId,int capacity,string sectionCode)
        {
            FloorId = floorId;
            Capacity = capacity;
            SectionCode = sectionCode;
        }

    }
}
