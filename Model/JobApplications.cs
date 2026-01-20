using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Online_Job_Management_System_Kamao.Model
{
    public class JobApplications 
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddJobApplication(JobApplication jobApplication)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO JobApplication (jobApplicationId, jobApplicationDate, jobSeekerId, jobSeekerEmail, jobSeekerSKill, jobId, jobTitle,jobCreator) VALUES (@jobApplicationId, @jobApplicationDate, @jobSeekerId, @jobSeekerEmail, @jobSeekerSKill, @jobId, @jobTitle, @jobCreator);");
            cmd.Parameters.AddWithValue("@jobApplicationId", jobApplication.JobApplicationId);
            cmd.Parameters.AddWithValue("@jobApplicationDate", jobApplication.JobApplicationDate);
            cmd.Parameters.AddWithValue("@jobSeekerId", jobApplication.JobSeekerId);
            cmd.Parameters.AddWithValue("@jobSeekerEmail", jobApplication.JobSeekerEmail);
            cmd.Parameters.AddWithValue("@jobSeekerSKill", jobApplication.JobSeekerSKill);
            cmd.Parameters.AddWithValue("@jobId", jobApplication.JobId);
            cmd.Parameters.AddWithValue("@jobTitle", jobApplication.JobTitle);
            cmd.Parameters.AddWithValue("@jobCreator", jobApplication.JobCreator);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateJobApplication(JobApplication jobApplication)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE JobApplication SET jobApplicationDate=@jobApplicationDate, jobSeekerId=@jobSeekerId, jobSeekerEmail=@jobSeekerEmail, jobSeekerSKill=@jobSeekerSKill, jobId=@jobId, jobTitle=@jobTitle, jobCreator=@jobCreator WHERE jobApplicationId = @jobApplicationId;");
            cmd.Parameters.AddWithValue("@jobApplicationId", jobApplication.JobApplicationId);
            cmd.Parameters.AddWithValue("@jobApplicationDate", jobApplication.JobApplicationDate);
            cmd.Parameters.AddWithValue("@jobSeekerId", jobApplication.JobSeekerId);
            cmd.Parameters.AddWithValue("@jobSeekerEmail", jobApplication.JobSeekerEmail);
            cmd.Parameters.AddWithValue("@jobSeekerSKill", jobApplication.JobSeekerSKill);
            cmd.Parameters.AddWithValue("@jobId", jobApplication.JobId);
            cmd.Parameters.AddWithValue("@jobTitle", jobApplication.JobTitle);
            cmd.Parameters.AddWithValue("@jobCreator", jobApplication.JobCreator);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteJobApplication(string jobApplicationId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM JobApplication WHERE jobApplicationId = @jobApplicationId;");
            cmd.Parameters.AddWithValue("@jobApplicationId", jobApplicationId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteJobApplicationByJobId(string jobId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM JobApplication WHERE jobId = @jobId;");
            cmd.Parameters.AddWithValue("@jobId", jobId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteJobApplicationByJobCreator(string jobCreator)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM JobApplication WHERE jobCreator = @jobCreator;");
            cmd.Parameters.AddWithValue("@jobCreator", jobCreator);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteJobApplicationByJobSeekerId(string jobSeekerId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM JobApplication WHERE jobSeekerId = @jobSeekerId;");
            cmd.Parameters.AddWithValue("@jobSeekerId", jobSeekerId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public List<JobApplication> GetJobApplications(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<JobApplication> jobApplicationList = new List<JobApplication>();
            using (reader)
            {
                while (reader.Read())
                {
                    JobApplication jobApplication = new JobApplication
                    {
                        JobApplicationId = reader.GetString(0),
                        JobApplicationDate = reader.GetDateTime(1),
                        JobSeekerId = reader.GetString(2),
                        JobSeekerEmail = reader.GetString(3),
                        JobSeekerSKill = reader.GetString(4),
                        JobId = reader.GetString(5),
                        JobTitle = reader.GetString(6),
                        JobCreator=reader.GetString(7)
                    };
                    jobApplicationList.Add(jobApplication);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return jobApplicationList;
        }
        public JobApplication SearchJobApplication(string jobApplicationId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobApplication WHERE jobApplicationId=@jobApplicationId;");
            cmd.Parameters.AddWithValue("@jobApplicationId", jobApplicationId);
            cmd.CommandType = CommandType.Text;
            List<JobApplication> jobApplicationList = GetJobApplications(cmd);
            if (jobApplicationList.Count > 0)
            {
                return jobApplicationList[0];
            }
            else
            {
                return null;
            }
        }
        public JobApplication CheckedApply(string jobId,string jobSeekerId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobApplication WHERE jobId=@jobId AND jobSeekerId=@jobSeekerId;");
            cmd.Parameters.AddWithValue("@jobId", jobId);
            cmd.Parameters.AddWithValue("@jobSeekerId", jobSeekerId);
            cmd.CommandType = CommandType.Text;
            List<JobApplication> jobApplicationList = GetJobApplications(cmd);
            if (jobApplicationList.Count > 0)
            {
                return jobApplicationList[0];
            }
            else
            {
                return null;
            }

        }
        public List<JobApplication> GetJobApplicationsByJobId(string jobId,string jobCreator)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobApplication WHERE jobId=@jobId AND jobCreator=@jobCreator;");
            cmd.Parameters.AddWithValue("@jobId", jobId);
            cmd.Parameters.AddWithValue("@jobCreator", jobCreator);
            cmd.CommandType = CommandType.Text;
            return GetJobApplications(cmd);
        }
        public List<JobApplication> GetJobApplicationsByJobSeekerId(string jobSeekerId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobApplication WHERE jobSeekerId=@jobSeekerId;");
            cmd.Parameters.AddWithValue("@jobSeekerId", jobSeekerId);
            cmd.CommandType = CommandType.Text;
            return GetJobApplications(cmd);
        }
        public List<JobApplication> GetJobApplicationsByJobCreator(string jobCreator)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobApplication WHERE jobCreator=@jobCreator;");
            cmd.Parameters.AddWithValue("@jobCreator", jobCreator);
            cmd.CommandType = CommandType.Text;
            return GetJobApplications(cmd);
        }
        public List<JobApplication> GetAllJobApplications()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobApplication;");
            cmd.CommandType = CommandType.Text;
            return GetJobApplications(cmd);
        }
    }
}
