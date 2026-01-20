using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Server;

namespace Online_Job_Management_System_Kamao.Model
{
    public class Recruiters 
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddRecruiter(Recruiter r)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Recruiter VALUES (@recruiterId, @recruiterName, @recruiterPassword, @recruiterEmail, @recruiterCompany, @role, @adminId);");
            cmd.Parameters.AddWithValue("@recruiterId", r.RecruiterId);
            cmd.Parameters.AddWithValue("@recruiterName", r.RecruiterName);
            cmd.Parameters.AddWithValue("@recruiterPassword", r.RecruiterPassword);
            cmd.Parameters.AddWithValue("@recruiterEmail", r.RecruiterEmail);
            cmd.Parameters.AddWithValue("@recruiterCompany", r.RecruiterCompany);
            cmd.Parameters.AddWithValue("@role", r.Role);
            cmd.Parameters.AddWithValue("@adminId", r.AdminId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateRecruiter(Recruiter r)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Recruiter SET recruiterId=@recruiterId, recruiterName=@recruiterName, recruiterPassword=@recruiterPassword, recruiterEmail=@recruiterEmail, recruiterCompany=@recruiterCompany, role=@role, adminId=@adminId WHERE recruiterId = @recruiterId;");
            cmd.Parameters.AddWithValue("@recruiterId", r.RecruiterId);
            cmd.Parameters.AddWithValue("@recruiterName", r.RecruiterName);
            cmd.Parameters.AddWithValue("@recruiterPassword", r.RecruiterPassword);
            cmd.Parameters.AddWithValue("@recruiterEmail", r.RecruiterEmail);
            cmd.Parameters.AddWithValue("@recruiterCompany", r.RecruiterCompany);
            cmd.Parameters.AddWithValue("@role", r.Role);
            cmd.Parameters.AddWithValue("@adminId", r.AdminId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteRecruiter(string recruiterId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Recruiter WHERE recruiterId=@recruiterId;");
            cmd.Parameters.AddWithValue("@recruiterId", recruiterId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<Recruiter> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Recruiter> recruiterList = new List<Recruiter>();
            using (reader)
            {
                while (reader.Read())
                {
                    Recruiter r = new Recruiter();
                    r.RecruiterId = reader.GetString(0);
                    r.RecruiterName = reader.GetString(1);
                    r.RecruiterPassword = reader.GetString(2);
                    r.RecruiterEmail = reader.GetString(3);
                    r.RecruiterCompany = reader.GetString(4);
                    recruiterList.Add(r);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return recruiterList;
        }

        public Recruiter SearchRecruiter(string recruiterId, string recruiterPassword)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Recruiter WHERE recruiterId=@recruiterId AND recruiterPassword=@recruiterPassword;");
            cmd.Parameters.AddWithValue("@recruiterId", recruiterId);
            cmd.Parameters.AddWithValue("@recruiterPassword", recruiterPassword);
            cmd.CommandType = CommandType.Text;
            List<Recruiter> recruiterList = GetData(cmd);
            if (recruiterList.Count > 0)
            {
                return recruiterList[0];
            }
            else
            {
                return null;
            }
        }
        public Recruiter SearchRecruiterEmail(string recruiterId, string recruiterEmail)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Recruiter WHERE recruiterId=@recruiterId AND recruiterEmail=@recruiterEmail;");
            cmd.Parameters.AddWithValue("@recruiterId", recruiterId);
            cmd.Parameters.AddWithValue("@recruiterEmail", recruiterEmail);
            cmd.CommandType = CommandType.Text;
            List<Recruiter> recruiterList = GetData(cmd);
            if (recruiterList.Count > 0)
            {
                return recruiterList[0];
            }
            else
            {
                return null;
            }
        }

        public List<Recruiter> GetAllRecruiter()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Recruiter;");
            cmd.CommandType = CommandType.Text;

            List<Recruiter> jsList = GetData(cmd);

            return jsList;
        }


    }
}
