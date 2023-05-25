using Npgsql;
using System;
using System.Collections.Generic;

namespace TaskManager.Database
{
    public class Postgres
    {
        private static String ConnectionString = "Host=localhost;Username=postgres;Password=1234;Database=Task Manager";
        private static NpgsqlConnection getConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
            return connection;
        }
        private static Department readDrDepartment(NpgsqlDataReader dr)
        {
            Department result = new Department();
            result.Id = int.Parse(dr["id"].ToString());
            result.Name = dr["name"].ToString();

            return result;
        }
        public static Department GetDepartment(int Id)
        {
            string sql = "SELECT * from department Where id=:Id";

            Department result = null;
            NpgsqlConnection conn = getConnection();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            try
            {
                conn.Open();
                cmd.Parameters.Add(new NpgsqlParameter(":Id", Id));
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        result = readDrDepartment(dr);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        private static Employer ReadDrPerson(NpgsqlDataReader dr)
        {
            Employer result = new Employer();
            object tmp = null;
            result.TabNum = dr.GetInt32(dr.GetOrdinal("Id"));
            result.Surname = dr["Surname"].ToString();
            result.Name = dr["Name"].ToString();

            int? idDepartment = (dr["Department"] != null && dr["Department"] != DBNull.Value ? int.Parse(dr["Department"].ToString()) : (int?)null);
            if (idDepartment != null)
            {
                result.Department = GetDepartment((int)idDepartment);
            }
            return result;
        }
        public static List<Employer> GetAllEmployers()
        {
            List<Employer> result = new List<Employer>();
            NpgsqlConnection conn = getConnection();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from employer ";
            try
            {
                conn.Open();

                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        result.Add(ReadDrPerson(dr));
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
    }
}
