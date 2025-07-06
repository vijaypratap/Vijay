using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace QueryBotWeb.Services
{
    public class SqlService
    {
        private readonly string _connectionString;

        public SqlService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public string ExecuteQuery(string sql)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        var result = new System.Text.StringBuilder();
                        // Add column headers
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            result.Append(reader.GetName(i)).Append(i < reader.FieldCount - 1 ? " | " : "\n");
                        }
                        // Add rows
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                result.Append(reader[i]?.ToString()).Append(i < reader.FieldCount - 1 ? " | " : "\n");
                            }
                        }
                        return result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return $"SQL Error: {ex.Message}";
            }
        }
    }
}
