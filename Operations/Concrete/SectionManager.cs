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
using ParkingSystem.Models.ViewModels;

namespace ParkingSystem.Operations.Concrete
{
    public class SectionManager : ISectionOperation
    {
        public IResult Add(Section entity)
        {
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_AddSection";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FloorId", entity.FloorId);
                cmd.Parameters.AddWithValue("@Capacity", entity.Capacity);
                cmd.Parameters.AddWithValue("@SectionCode", entity.SectionCode);

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
                cmd.CommandText = "sp_DeleteSection";
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

        public IDataResult<Section> Get(int id)
        {
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_GetSection";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                Section model = new Section();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt.Rows[i];
                    model.ID = int.Parse(row["ID"].ToString());
                    model.FloorId = int.Parse(row["FloorId"].ToString());
                    model.Capacity = int.Parse(row["Capacity"].ToString());
                    model.SectionCode = row["SectionCode"].ToString();
                    model.Deleted = int.Parse(row["Deleted"].ToString());
                    break;
                }
                return new SuccessDataResult<Section>(model);

            }
            catch (Exception ex) when (ex is SqlException)
            {

                return new ErrorDataResult<Section>(ex.Message);
            }
            finally
            {
                DatabaseConnection.Connection.Close();
            }
        }

        public IDataResult<List<Section>> GetAll()
        {
            List<Section> result = new List<Section>();
            Section model;
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_GetAllSections";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];



                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Section();
                    var row = dt.Rows[i];
                    model.ID = int.Parse(row["ID"].ToString());
                    model.FloorId = int.Parse(row["FloorId"].ToString());
                    model.Capacity = int.Parse(row["Capacity"].ToString());
                    model.SectionCode = row["SectionCode"].ToString();
                    model.Deleted = int.Parse(row["Deleted"].ToString());
                    result.Add(model);
                }
                return new SuccessDataResult<List<Section>>(result);

            }
            catch (Exception ex) when (ex is SqlException)
            {

                return new ErrorDataResult<List<Section>>(ex.Message);
            }
            finally
            {
                DatabaseConnection.Connection.Close();
            }
        }

        public IDataResult<List<SectionVM>> GetSectionDetails()
        {
            List<SectionVM> result = new List<SectionVM>();
            SectionVM model;
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_GetSectionDetails";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];



                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new SectionVM();
                    var row = dt.Rows[i];
                    model.ID = int.Parse(row["ID"].ToString());
                    model.FloorNumber = int.Parse(row["FloorNumber"].ToString());
                    model.Capacity = int.Parse(row["Capacity"].ToString());
                    model.SectionCode = row["SectionCode"].ToString();
                    model.Deleted = int.Parse(row["Deleted"].ToString());
                    result.Add(model);
                }
                return new SuccessDataResult<List<SectionVM>>(result);

            }
            catch (Exception ex) when (ex is SqlException)
            {

                return new ErrorDataResult<List<SectionVM>>(ex.Message);
            }
            finally
            {
                DatabaseConnection.Connection.Close();
            }
        }

        public IResult Update(Section entity)
        {
            try
            {
                var cmd = DatabaseConnection.Connection.CreateCommand();
                cmd.CommandText = "sp_UpdateSection";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FloorId", entity.FloorId);
                cmd.Parameters.AddWithValue("@Capacity", entity.Capacity);
                cmd.Parameters.AddWithValue("@SectionCode", entity.SectionCode);
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
