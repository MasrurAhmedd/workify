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
    public class JobSeekerController
    {
        public void AddJobSeeker(JobSeeker js)
        {
            JobSeekers jobSeekers = new JobSeekers();
            jobSeekers.AddJobSeeker(js);
        }
        public void UpdateJobSeeker(JobSeeker js)
        {
            JobSeekers jobSeekers = new JobSeekers();
            jobSeekers.UpdateJobSeeker(js);
        }
        public void DeleteJobSeeker(string jobSeekerId)
        {
            JobSeekers jobSeekers = new JobSeekers();
            jobSeekers.DeleteJobSeeker(jobSeekerId);
        }
        public JobSeeker SearchJobSeeker(string jobSeekerId, string jobSeekerPassword)
        {
            JobSeekers jobSeekers = new JobSeekers();
            JobSeeker j=jobSeekers.SearchJobSeeker(jobSeekerId, jobSeekerPassword);
            return j;
        }
        public JobSeeker SearchJobSeekerEmail(string jobSeekerId, string jobSeekerEmail)
        {
            JobSeekers jobSeekers = new Model.JobSeekers();
            JobSeeker j=jobSeekers.SearchJobSeekerEmail(jobSeekerId, jobSeekerEmail);
            return j;
        }
        public List<JobSeeker> GetAllJobSeeker()
        {
            JobSeekers jss = new JobSeekers();
            List<JobSeeker> jsList = jss.GetAllJobSeeker();
            return jsList;

        }
    }
}
