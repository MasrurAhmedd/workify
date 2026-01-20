using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Online_Job_Management_System_Kamao.Model;

namespace Online_Job_Management_System_Kamao.Controller
{
    public class JobCountController
    {
        public void UpdateJobCount(JobCount jc)
        {
            JobCounts jcs = new JobCounts();
            jcs.UpdateJobCount(jc);
        }
        public List<JobCount> GetJobCounts(SqlCommand cmd)
        {
            JobCounts jcs = new JobCounts();
            return jcs.GetData(cmd);
        }
        public JobCount SearchJobCount(int jobCountId)
        {
            JobCounts jcs = new JobCounts();
            return jcs.SearchCount(jobCountId);
        }
    }
}
