using Microsoft.Data.SqlClient;
using System.Data;

namespace SchoolManagementERP.SqlHelper
{
    public class SqlHelpers
    {
        public readonly IConfiguration _Configuration;
        public SqlHelpers(IConfiguration configuration) 
        {
            _Configuration = configuration;
        }


        public DataTable ExecuteDataTable(
               string Query,
               string proc,
           SqlParameter[] param)
        {
              DataTable dt = new DataTable();

              using (SqlConnection con = new SqlConnection(
                  _Configuration.GetConnectionString("DefaultConnection")))
              {
                  SqlCommand cmd;

                  if (string.IsNullOrWhiteSpace(Query))
                  {
                      cmd = new SqlCommand(proc, con);
                      cmd.CommandType = CommandType.StoredProcedure;
                  }
                  else
                  {
                      cmd = new SqlCommand(Query, con);
                      cmd.CommandType = CommandType.Text;
                  }

                  using (cmd)
                  {
                      if (param != null && param.Length > 0)
                      {
                          cmd.Parameters.AddRange(param);
                      }

                      using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                      {
                          da.Fill(dt);
                      }
                  }
              }

                return dt;
        }
    }
}
