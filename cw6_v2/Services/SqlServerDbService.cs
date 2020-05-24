using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace cw6_v2.Services
{
    public class SqlServerDbServiceIStudentsDbService : IHospitalDbService
    {
        public static IConfiguration Configuration { get; }

        private string connectionString = Configuration.GetConnectionString("myconn");

        private SqlConnection connection;

        public SqlServerDbServiceIStudentsDbService()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void ExecuteInsert(SqlCommand command)
        {
            connection.Open();
            var transaction = connection.BeginTransaction();
            try
            {
                command.Connection = connection;
                command.Transaction = transaction;
                command.ExecuteScalar();
            }
            catch (SqlException)
            {
                transaction.Rollback();
            }
        }

        public List<object[]> ExecuteSelect(SqlCommand command)
        {
            List<object[]> result = new List<object[]>();
            connection.Open();
            var transaction = connection.BeginTransaction();
            try
            {
                command.Connection = connection;
                command.Transaction = transaction;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object[] newObject = new object[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newObject[i] = reader[i];
                    }

                    result.Add(newObject);
                }

                reader.Close();
            }
            catch (SqlException)
            {
                transaction.Rollback();
            }

            connection.Close();
            return result;
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}