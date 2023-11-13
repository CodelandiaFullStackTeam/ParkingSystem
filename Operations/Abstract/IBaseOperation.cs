using ParkingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Operations.Abstract
{
    public interface IBaseOperation<T> where T : BaseModel, new()
    {
        IResult Add(T entity);
        IResult Delete(int id);
        IResult Update(T entity);
        IDataResult<T> Get(int id);
        IDataResult<List<T>> GetAll();
    }
}
