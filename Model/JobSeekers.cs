using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Online_Job_Management_System_Kamao.Model
{
    public class JobSeekers 
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddJobSeeker(JobSeeker js)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO JobSeeker   VALUES (@jobSeekerId, @jobSeekerName, @jobSeekerPassword, @jobSeekerGender, @jobSeekerEmail, @jobSeekerSkill,@role,@adminId);");
            cmd.Parameters.AddWithValue("@jobSeekerId", js.JobSeekerId);
            cmd.Parameters.AddWithValue("@jobSeekerName", js.JobSeekerName);
            cmd.Parameters.AddWithValue("@jobSeekerPassword", js.JobSeekerPassword);
            cmd.Parameters.AddWithValue("@jobSeekerGender", js.JobSeekerGender);
            cmd.Parameters.AddWithValue("@jobSeekerEmail", js.JobSeekerEmail);
            cmd.Parameters.AddWithValue("@jobSeekerSkill", js.JobSeekerSkill);
            cmd.Parameters.AddWithValue("@role", js.Role);
            cmd.Parameters.AddWithValue("@adminId", js.AdminId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateJobSeeker(JobSeeker js)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE JobSeeker SET jobSeekerId=@jobSeekerId, jobSeekerName=@jobSeekerName, jobSeekerPassword=@jobSeekerPassword, jobSeekerGender=@jobSeekerGender, jobSeekerEmail=@jobSeekerEmail, jobSeekerSkill=@jobSeekerSkill, role=@role, adminId=@adminId WHERE jobSeekerId = @jobSeekerId;");
            cmd.Parameters.AddWithValue("@jobSeekerId", js.JobSeekerId);
            cmd.Parameters.AddWithValue("@jobSeekerName", js.JobSeekerName);
            cmd.Parameters.AddWithValue("@jobSeekerPassword", js.JobSeekerPassword);
            cmd.Parameters.AddWithValue("@jobSeekerGender", js.JobSeekerGender);
            cmd.Parameters.AddWithValue("@jobSeekerEmail", js.JobSeekerEmail);
            cmd.Parameters.AddWithValue("@jobSeekerSkill", js.JobSeekerSkill);
            cmd.Parameters.AddWithValue("@role", js.Role);
            cmd.Parameters.AddWithValue("@adminId", js.AdminId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteJobSeeker(string jobSeekerId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM JobSeeker WHERE jobSeekerId=@jobSeekerId;");
            cmd.Parameters.AddWithValue("@jobSeekerId", jobSeekerId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<JobSeeker> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<JobSeeker> jobSeekerList = new List<JobSeeker>();
            using (reader)
            {
                while (reader.Read())
                {
                    JobSeeker js = new JobSeeker();
                    js.JobSeekerId = reader.GetString(0);
                    js.JobSeekerName = reader.GetString(1);
                    js.JobSeekerPassword = reader.GetString(2);
                    js.JobSeekerGender = reader.GetString(3);
                    js.JobSeekerEmail = reader.GetString(4);
                    js.JobSeekerSkill = reader.GetString(5);

                    jobSeekerList.Add(js);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return jobSeekerList;
        }
        public JobSeeker SearchJobSeeker(string jobSeekerId,string jobSeekerPassword)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobSeeker WHERE jobSeekerId=@jobSeekerId AND jobSeekerPassword=@jobSeekerPassword;");
            cmd.Parameters.AddWithValue("@jobSeekerId", jobSeekerId);
            cmd.Parameters.AddWithValue("@jobSeekerPassword", jobSeekerPassword);
            cmd.CommandType = CommandType.Text;
            List<JobSeeker> jobSeekerList = GetData(cmd);
            if (jobSeekerList.Count > 0)
            {
                return jobSeekerList[0];
            }
            else
            {
                return null;
            }

        }
        
        public JobSeeker SearchJobSeekerEmail(string jobSeekerId,string jobSeekerEmail)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobSeeker WHERE jobSeekerId=@jobSeekerId AND jobSeekerEmail=@jobSeekerEmail;");
            cmd.Parameters.AddWithValue("@jobSeekerId", jobSeekerId);
            cmd.Parameters.AddWithValue("@jobSeekerEmail", jobSeekerEmail);
            cmd.CommandType = CommandType.Text;
            List<JobSeeker> jobSeekerList = GetData(cmd);
            if (jobSeekerList.Count > 0)
            {
                return jobSeekerList[0];
            }
            else
            {
                return null;
            }

        }
        public List<JobSeeker> GetAllJobSeeker()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobSeeker;");
            cmd.CommandType = CommandType.Text;

            List<JobSeeker> jsList = GetData(cmd);

            return jsList;
        }
    }
    
}
