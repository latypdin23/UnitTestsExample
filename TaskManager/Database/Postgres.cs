using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using TaskManager.Model;

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
        private static object getDBNull(object value)
        {
            if (value == null)
                return DBNull.Value;
            return value;
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
            string sql = "SELECT * from public.department Where id=:Id";

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
        public static Employer GetEmployer(int Id)
        {
            string sql = "SELECT * from public.employer Where tabnum=:Id";

            Employer result = null;
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
                        result = ReadDrPerson(dr);
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
        public static Status GetStatus(int Id)
        {
            string sql = "SELECT * from public.status Where id=:Id";

            Status result = null;
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
                        result = ReadDrStatus(dr);
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
        public static Project GetProject(int Id)
        {
            string sql = "SELECT * from public.project Where id=:Id";

            Project result = null;
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
                        result = ReadDrProject(dr);
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
            result.TabNum = dr.GetInt32(dr.GetOrdinal("TabNum"));
            result.Surname = dr["Surname"].ToString();
            result.Name = dr["Name"].ToString();
            result.DateOfBirth = Convert.ToDateTime(dr["dateOfBirth"].ToString());

            int? idDepartment = (dr["Department"] != null && dr["Department"] != DBNull.Value ? int.Parse(dr["Department"].ToString()) : (int?)null);
            if (idDepartment != null)
            {
                result.Department = GetDepartment((int)idDepartment);
            }
            return result;
        }
        private static Status ReadDrStatus(NpgsqlDataReader dr)
        {
            Status result = new Status();
            object tmp = null;
            result.Id = dr.GetInt32(dr.GetOrdinal("Id"));
            result.Name = dr["Name"].ToString();
            
            return result;
        }
        private static Project ReadDrProject(NpgsqlDataReader dr)
        {
            Project result = new Project();
            object tmp = null;
            result.Id = dr.GetInt32(dr.GetOrdinal("Id"));
            result.Name = dr["Name"].ToString();
            result.DateStart = Convert.ToDateTime(dr["datestart"].ToString());
            result.DateEnd = Convert.ToDateTime(dr["dateend"].ToString());

            int? idteamlead = (dr["teamlead"] != null && dr["teamlead"] != DBNull.Value ? int.Parse(dr["teamlead"].ToString()) : (int?)null);
            if (idteamlead != null)
            {
                result.TeamLead = GetEmployer((int)idteamlead);
            }

            int? idstatus = (dr["status"] != null && dr["status"] != DBNull.Value ? int.Parse(dr["status"].ToString()) : (int?)null);
            if (idstatus != null)
            {
                result.Status = GetStatus((int)idstatus);
            }
            return result;
        }
        private static Task ReadDrTask(NpgsqlDataReader dr)
        {
            Task result = new Task();
            object tmp = null;
            result.Id = dr.GetInt32(dr.GetOrdinal("Id"));
            result.Description = dr["Description"].ToString();
            result.DateStart = Convert.ToDateTime(dr["datestart"].ToString());
            result.DateEnd = Convert.ToDateTime(dr["dateend"].ToString());

            int? idinitiator = (dr["initiator"] != null && dr["initiator"] != DBNull.Value ? int.Parse(dr["initiator"].ToString()) : (int?)null);
            if (idinitiator != null)
            {
                result.Initiator = GetEmployer((int)idinitiator);
            }
            int? idispolnitel = (dr["ispolnitel"] != null && dr["ispolnitel"] != DBNull.Value ? int.Parse(dr["ispolnitel"].ToString()) : (int?)null);
            if (idispolnitel != null)
            {
                result.Ispolnitel = GetEmployer((int)idispolnitel);
            }

            int? idstatus = (dr["status"] != null && dr["status"] != DBNull.Value ? int.Parse(dr["status"].ToString()) : (int?)null);
            if (idstatus != null)
            {
                result.Status = GetStatus((int)idstatus);
            }

            int? idproject = (dr["project"] != null && dr["project"] != DBNull.Value ? int.Parse(dr["project"].ToString()) : (int?)null);
            if (idproject != null)
            {
                result.project = GetProject((int)idproject);
            }
            return result;
        }
        public static List<Employer> GetAllEmployers()
        {
            List<Employer> result = new List<Employer>();
            NpgsqlConnection conn = getConnection();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from public.employer ";
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
        public static List<Project> GetAllProjects()
        {
            List<Project> result = new List<Project>();
            NpgsqlConnection conn = getConnection();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from public.project ";
            try
            {
                conn.Open();

                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        result.Add(ReadDrProject(dr));
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
        public static List<Task> GetAllTasks()
        {
            List<Task> result = new List<Task>();
            NpgsqlConnection conn = getConnection();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from public.task ";
            try
            {
                conn.Open();

                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        result.Add(ReadDrTask(dr));
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
        public static bool SaveTask(Task newData)
        {
            string sqlIns = "INSERT INTO public.task(description, datestart, dateend, initiator, ispolnitel, project, status) " +
                   "VALUES(:description, :datestart, :dateend, :initiator, :ispolnitel, :project, :status) RETURNING Id INTO :Id";
            string sqlUpd = "UPDATE public.task SET id=:id, description=:description, datestart=:datestart, dateend=:dateend, initiator=:initiator, ispolnitel=:initiator, project=:project, status=:status " +
                    "WHERE Id=:Id";
            bool result = false;
            NpgsqlConnection conn = null;
            try
            {
                conn = getConnection();
                conn.Open();
                NpgsqlTransaction tr = conn.BeginTransaction();
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = (newData.Id == 0 ? sqlIns : sqlUpd);

                cmd.Parameters.Add(new NpgsqlParameter(":description", getDBNull(newData.Description)));
                cmd.Parameters.Add(new NpgsqlParameter(":datestart", getDBNull(newData.DateStart)));
                cmd.Parameters.Add(new NpgsqlParameter(":dateend", getDBNull(newData.DateEnd)));
                cmd.Parameters.Add(new NpgsqlParameter(":initiator", getDBNull(newData.Initiator.TabNum)));
                cmd.Parameters.Add(new NpgsqlParameter(":ispolnitel", getDBNull(newData.Ispolnitel.TabNum)));
                cmd.Parameters.Add(new NpgsqlParameter(":project", getDBNull(newData.project.Id)));
                cmd.Parameters.Add(new NpgsqlParameter(":status", getDBNull(newData.Status.Id)));

                //if (newData.Id == 0)
                //    cmd.Parameters.Add(":Id", NpgsqlDbType.Bigint);
                //else
                //    cmd.Parameters.Add(new NpgsqlParameter(":Id", getDBNull(newData.Id)));

                try
                {
                    cmd.ExecuteNonQuery();
                    tr.Commit();
                    if (newData.Id == 0)
                    {
                        newData.Id = int.Parse(cmd.Parameters[":Id"].Value.ToString());
                    }
                    result = true;
                }
                catch(Exception e)
                {
                    tr.Rollback();
                }
            }
            catch (Exception)
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
