using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Helpers
{
    public class DatabaseConnection
    {
        private static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get
            {
                if (_connection is null)
                {
                    _connection = new SqlConnection(Constants.CONNECTION_STRING);
                }

                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }

        private DatabaseConnection() { }


    }
}
