using ParkingSystem.Models;
using ParkingSystem.Models.ViewModels;

namespace ParkingSystem.Operations.Abstract
{
    public interface ISectionOperation : IBaseOperation<Section>
    {
        IDataResult<List<SectionVM>> GetSectionDetails();
    }
}
