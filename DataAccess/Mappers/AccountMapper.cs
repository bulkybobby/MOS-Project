using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.Data.SqlClient;

namespace DataAccess.Mappers
{
    internal class AccountMapper
    {
        private string connectionString =
            "Data Source=localhost;User ID=sa;Password=********;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public async Task<Test> Create(Test test)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    await sqlConnection.OpenAsync();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "INSERT INTO Test(userid,username,point) OUTPUT INSERTED.ID VALUES(@userid,@username,@point)";
                    sqlCommand.Parameters.AddWithValue("@userid", test.UserId);
                    sqlCommand.Parameters.AddWithValue("@username", test.UserName);
                    sqlCommand.Parameters.AddWithValue("@age", test.Age);
                    int id = Convert.ToInt32(await sqlCommand.ExecuteScalarAsync());
                    test.Id = id;

                    return test;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
