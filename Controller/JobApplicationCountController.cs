using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Job_Management_System_Kamao.Model;

namespace Online_Job_Management_System_Kamao.Controller
{
    public class JobApplicationCountController
    {
        public void UpdateJobApplicationCount(JobApplicationCount jobApplicationCount)
        {
            JobApplicationCounts jobApplicationCountsModel = new JobApplicationCounts();
            jobApplicationCountsModel.UpdateJobApplicationCount(jobApplicationCount);
        }
        public JobApplicationCount SearchJobApplicationCount(int jobApplicationCountId)
        {
            JobApplicationCounts jobApplicationCountsModel = new JobApplicationCounts();
            return jobApplicationCountsModel.SearchJobApplicationCount(jobApplicationCountId);
        }
    }
}
