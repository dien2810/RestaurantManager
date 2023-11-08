using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class DataProvider
    {
        public static string ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuanLyNhaHangAnUong;Integrated Security=True";
        public static SqlConnection Connection;
        public static void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        public static void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        public static DataTable ExecuteQuery(string Query, ref string ErrMsg, object[] ParameterValues = null)
        {
            //ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuanLyNhaHangAnUong;Integrated Security=True";
            DataTable Table = new DataTable();
            try
            {
                using (Connection = new SqlConnection(ConnectionString))
                {
                    OpenConnection();
                    SqlCommand cmd = new SqlCommand(Query, Connection);
                    if (ParameterValues != null)
                    {
                        string[] Parameters = Query.Split(' ');
                        int i = 0;
                        foreach (string param in Parameters)
                        {
                            if (param.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(param, ParameterValues[i++]);
                            }
                        }
                    }
                    SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
                    DataAdapter.Fill(Table);
                }
            }
            catch (Exception e) { ErrMsg = e.Message; }
            finally { CloseConnection(); }
            return Table;
        }
        public static int ExecuteNonQuery(string Query, ref string ErrMsg, object[] ParameterValues = null)
        {
            //ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuanLyNhaHangAnUong;Integrated Security=True";
            int rowsAffected = 0;
            try
            {
                using(Connection = new SqlConnection(ConnectionString))
                {
                    OpenConnection();
                    SqlCommand cmd = new SqlCommand(Query, Connection);
                    if (ParameterValues != null)
                    {
                        string[] Parameters = Query.Split(' ');
                        int i = 0;
                        foreach(string param in Parameters)
                        {
                            if(param.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(param, ParameterValues[i++]);
                            }
                        }
                    }
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch(Exception e) { ErrMsg = e.Message;}
            finally { CloseConnection(); }
            return rowsAffected;
        }
        public static object ExecuteScalar(string Query, ref string ErrMsg, object[] ParameterValues = null)
        {
            //ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuanLyNhaHangAnUong;Integrated Security=True";
            object Data = null;
            try
            {
                using (Connection = new SqlConnection(ConnectionString))
                {
                    OpenConnection();
                    SqlCommand cmd = new SqlCommand(Query, Connection);
                    if (ParameterValues != null)
                    {
                        string[] Parameters = Query.Split(' ');
                        int i = 0;
                        foreach (string param in Parameters)
                        {
                            if (param.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(param, ParameterValues[i++]);
                            }
                        }
                    }
                    Data = cmd.ExecuteScalar();
                }
            }
            catch (Exception e) { ErrMsg = e.Message; }
            finally { CloseConnection(); }
            return Data;
        }
        public static int NextID(string TableName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT IDEN_CURRENT('" + TableName + "')", Connection);
            int LastId = Convert.ToInt32(cmd.ExecuteScalar());
            CloseConnection();
            return LastId + 1;
        }
    }
}
