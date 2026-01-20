using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;


namespace Online_Job_Management_System_Kamao.Model
{
    public class Jobs
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddJob(Job job)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Job (jobId, jobTitle, jobSalary, jobDescription, jobPostDate, jobDeadline, jobCreator) VALUES (@jobId, @jobTitle, @jobSalary, @jobDescription, @jobPostDate, @jobDeadline, @jobCreator);");
            cmd.Parameters.AddWithValue("@jobId", job.JobId);
            cmd.Parameters.AddWithValue("@jobTitle", job.JobTitle);
            cmd.Parameters.AddWithValue("@jobSalary", job.JobSalary);
            cmd.Parameters.AddWithValue("@jobDescription", job.JobDescription);
            cmd.Parameters.AddWithValue("@jobPostDate", job.JobPostDate);
            cmd.Parameters.AddWithValue("@jobDeadline", job.JobDeadline);
            cmd.Parameters.AddWithValue("@jobCreator", job.JobCreator);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateJob(Job job)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Job SET jobTitle=@jobTitle, jobSalary=@jobSalary, jobDescription=@jobDescription, jobPostDate=@jobPostDate, jobDeadline=@jobDeadline, jobCreator=@jobCreator WHERE jobId = @jobId;");
            cmd.Parameters.AddWithValue("@jobId", job.JobId);
            cmd.Parameters.AddWithValue("@jobTitle", job.JobTitle);
            cmd.Parameters.AddWithValue("@jobSalary", job.JobSalary);
            cmd.Parameters.AddWithValue("@jobDescription", job.JobDescription);
            cmd.Parameters.AddWithValue("@jobPostDate", job.JobPostDate);
            cmd.Parameters.AddWithValue("@jobDeadline", job.JobDeadline);
            cmd.Parameters.AddWithValue("@jobCreator", job.JobCreator);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteJob(string jobId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Job WHERE jobId = @jobId;");
            cmd.Parameters.AddWithValue("@jobId", jobId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteJobByJobCreator(string jobCreator)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Job WHERE jobCreator = @jobCreator;");
            cmd.Parameters.AddWithValue("@jobCreator", jobCreator);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Job> GetJobs(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Job> jobList = new List<Job>();
            using (reader)
            {
                while (reader.Read())
                {
                    Job job = new Job();
                    job.JobId = reader.GetString(0);
                    job.JobTitle = reader.GetString(1);
                    
                    job.JobSalary = (float)reader.GetDouble(2);
                     

                    job.JobDescription = reader.GetString(3);
                    job.JobPostDate = reader.GetDateTime(4);
                    job.JobDeadline = reader.GetDateTime(5);
                    job.JobCreator = reader.GetString(6);
                    
                    jobList.Add(job);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return jobList;
        }
        public Job SearchJob(string jobId,string jobCreator)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Job WHERE jobId=@jobId AND jobCreator=@jobCreator;");
            cmd.Parameters.AddWithValue("@jobId", jobId);
            cmd.Parameters.AddWithValue("@jobCreator", jobCreator);
            cmd.CommandType = CommandType.Text;
            List<Job> jobList = GetJobs(cmd);
            if (jobList.Count > 0)
            {
                return jobList[0];
            }
            else
            {
                return null;
            }
        }
        public Job SearchJob(string jobId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Job WHERE jobId=@jobId ;");
            cmd.Parameters.AddWithValue("@jobId", jobId);
            cmd.CommandType = CommandType.Text;
            List<Job> jobList = GetJobs(cmd);
            if (jobList.Count > 0)
            {
                return jobList[0];
            }
            else
            {
                return null;
            }
        }

        public Job ApplyJob(string jobId,string jobTitle)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Job WHERE jobId=@jobId AND jobTitle=@jobTitle;");
            cmd.Parameters.AddWithValue("@jobId", jobId);
            cmd.Parameters.AddWithValue("@jobTitle", jobTitle);
            cmd.CommandType = CommandType.Text;
            List<Job> jobList = GetJobs(cmd);
            if (jobList.Count > 0)
            {
                return jobList[0];
            }
            else
            {
                return null;
            }
        }
        public List<Job> SearchJobByTitle(string jobTitle)
        {

            SqlCommand cmd = sda.GetQuery("SELECT * FROM Job WHERE jobTitle=@jobTitle ;");
            cmd.Parameters.AddWithValue("@jobTitle", jobTitle);
            cmd.CommandType = CommandType.Text;
            List<Job> jobList = GetJobs(cmd);
            return jobList;
        }
        public List<Job> SearchJobByCreator(string jobCreator)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Job WHERE jobCreator=@jobCreator;");
            cmd.Parameters.AddWithValue("@jobCreator", jobCreator);
            cmd.CommandType = CommandType.Text;
            return GetJobs(cmd);
        }
        public List<Job> GetAllJobs()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Job;");
            cmd.CommandType = CommandType.Text;
            return GetJobs(cmd);
        }
    }

}
