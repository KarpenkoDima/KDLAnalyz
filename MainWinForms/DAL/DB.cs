using Dapper;
using KDLAnalize.MainWinForms.BAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDLAnalize.MainWinForms.DAL
{
    public class DB
    {
        string conn = "Server=localhost;Database=SopbKdlAnalize;Trusted_Connection=True;";

        internal List<TypeAnalize> GetDict(string dict)
        {
            string sql = $"SELECT * FROM [GetAll{dict}View]";

            using (var connection = new SqlConnection(conn))
            {
                return connection.Query<TypeAnalize>(sql).ToList();
            }
        }
        internal List<Log> GetDictlog(string dict , string where = "")
        {
            string sql = $"SELECT * FROM [GetAll{dict}View]";// {where}";

            using (var connection = new SqlConnection(conn))
            {
                return connection.Query<Log>(sql).ToList();
            }
        }
    }
}
