using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class JobApplicationCounts 
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void UpdateJobApplicationCount(JobApplicationCount jac)
        {

            SqlCommand cmd = sda.GetQuery("UPDATE JobApplicationCount SET jobApplicationCountId=jobApplicationCountId,jobApplicationObjCount=@jobApplicationObjCount WHERE jobApplicationCountId = @jobApplicationCountId;");
            cmd.Parameters.AddWithValue("@jobApplicationCountId", jac.JobApplicationCountId);
            cmd.Parameters.AddWithValue("@jobApplicationObjCount", jac.JobApplicationObjCount);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<JobApplicationCount> GetJobApplicationCounts(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<JobApplicationCount> jobApplicationCountList = new List<JobApplicationCount>();
            using (reader)
            {
                while (reader.Read())
                {
                    JobApplicationCount jac = new JobApplicationCount(
                        reader.GetInt32(0),
                        reader.GetInt32(1)
                    );
                    jobApplicationCountList.Add(jac);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return jobApplicationCountList;
        }
        public JobApplicationCount SearchJobApplicationCount(int jobApplicationCountId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobApplicationCount WHERE jobApplicationCountId=@jobApplicationCountId;");
            cmd.Parameters.AddWithValue("@jobApplicationCountId", jobApplicationCountId);
            cmd.CommandType = CommandType.Text;
            List<JobApplicationCount> jobApplicationCountList = GetJobApplicationCounts(cmd);
            if (jobApplicationCountList.Count > 0)
            {
                return jobApplicationCountList[0];
            }
            else 
            {
                return null;
            }
                
        }
    }
}
