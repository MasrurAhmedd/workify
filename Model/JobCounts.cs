using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class JobCounts
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void UpdateJobCount(JobCount c)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE JobCount SET jobCountObj=@jobCountObj WHERE jobCountId = @jobCountId;");
            cmd.Parameters.AddWithValue("@jobCountId", c.JobCountId);
            cmd.Parameters.AddWithValue("@jobCountObj", c.JobCountObj);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


        public List<JobCount> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<JobCount> jobCountList = new List<JobCount>();
            using (reader)
            {
                while (reader.Read())
                {
                    JobCount c = new JobCount(reader.GetInt32(0), reader.GetInt32(1));
                    jobCountList.Add(c);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return jobCountList;
        }
        public JobCount SearchCount(int jobCountId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM JobCount WHERE jobCountId=@jobCountId;");
            cmd.Parameters.AddWithValue("@jobCountId", jobCountId);
            cmd.CommandType = CommandType.Text;
            List<JobCount> jobCountList = GetData(cmd);
            if (jobCountList.Count > 0)
            {
                return jobCountList[0];
            }
            else
            {
                return null;
            }
        }


    }
}
