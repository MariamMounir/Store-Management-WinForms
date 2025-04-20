using System.Data;
using Microsoft.Data.SqlClient;

namespace Layer1_connection
{

    public class DBManger
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public DBManger()
        {
            conn = new SqlConnection("Data Source=DESKTOP-08R05QG;Initial Catalog=Store;Integrated Security=True;Trust Server Certificate=True");
        }

        //with no parameter (return table)
        public DataTable ExecuteDataTable(string cmdText)
        {

            cmd = new SqlCommand(cmdText, conn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        //overwrite with parameter (return table)
        public DataTable ExecuteDataTable(string cmdText, Dictionary<string, object> Params)
        {
            try
            {
                cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.Clear();
                foreach (var p in Params)
                {
                    cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
                }

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        //return # row effected
        public int ExecuteNonQuery(string cmdText, Dictionary<string, object> Params)
        {
            int r = -1;
            try
            {
                cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.Clear();
                foreach (var p in Params)
                {
                    cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                r = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return r;
        }

        //return first col of first row
        public object ExecuteScalar(string cmdText, Dictionary<string, object> Params)
        {
            object result = null;
            try
            {
                cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.Clear();
                foreach (var p in Params)
                {
                    cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                result = cmd.ExecuteScalar(); 
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return result;
        }
    }


}
