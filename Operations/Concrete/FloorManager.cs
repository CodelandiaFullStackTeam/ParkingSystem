using ParkingSystem.Helpers;
using ParkingSystem.Models;
using ParkingSystem.Operations.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Operations.Concrete
{
    public class FloorManager : IFloorOperation
    {
        public IResult Add(Floor entity)
        {
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_AddFloor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FloorNumber", entity.FloorNumber);
                cmd.Parameters.AddWithValue("@Capacity", entity.Capacity);
                
                int res = cmd.ExecuteNonQuery();
                return new SuccessResult();
            }
            catch (Exception ex) when (ex is SqlException)
            {

                return new ErrorResult(ex.Message);
            }
            finally
            {
                DatabaseConnection.Connection.Close();
            }
        }

        public IResult Delete(int id)
        {
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_DeleteFloor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                int result = cmd.ExecuteNonQuery();
                return new SuccessResult();

            }
            catch (Exception ex) when (ex is SqlException)
            {

                return new ErrorResult(ex.Message);
            }
            finally
            {
                DatabaseConnection.Connection.Close();
            }
        }

        public IDataResult<Floor> Get(int id)
        {
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_GetFloor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                Floor model = new Floor();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt.Rows[i];
                    model.ID = int.Parse(row["ID"].ToString());
                    model.FloorNumber = int.Parse(row["FloorNumber"].ToString());
                    model.Capacity = int.Parse(row["Capacity"].ToString());
                    model.Deleted = int.Parse(row["Deleted"].ToString());
                    break;
                }
                return new SuccessDataResult<Floor>(model);

            }
            catch (Exception ex) when (ex is SqlException)
            {

                return new ErrorDataResult<Floor>(ex.Message);
            }
            finally
            {
                DatabaseConnection.Connection.Close();
            }
        }

        public IDataResult<List<Floor>> GetAll()
        {
            List<Floor> result = new List<Floor>();
            Floor model;
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_GetAllFloors";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

               

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Floor();
                    var row = dt.Rows[i];
                    model.ID = int.Parse(row["ID"].ToString());
                    model.FloorNumber = int.Parse(row["FloorNumber"].ToString());
                    model.Capacity = int.Parse(row["Capacity"].ToString());
                    model.Deleted = int.Parse(row["Deleted"].ToString());
                    result.Add(model);
                }
                return new SuccessDataResult<List<Floor>>(result);

            }
            catch (Exception ex) when (ex is SqlException)
            {

                return new ErrorDataResult<List<Floor>>(ex.Message);
            }
            finally
            {
                DatabaseConnection.Connection.Close();
            }
        }

        public IResult Update(Floor entity)
        {
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_UpdateSection";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FloorNumber", entity.FloorNumber);
                cmd.Parameters.AddWithValue("@Capacity", entity.Capacity);
                cmd.Parameters.AddWithValue("@ID", entity.ID);

                int result = cmd.ExecuteNonQuery();
                return new SuccessResult();

            }
            catch (Exception ex) when (ex is SqlException)
            {

                return new ErrorResult(ex.Message);
            }
            finally
            {
                DatabaseConnection.Connection.Close();
            }
        }
    }
}
