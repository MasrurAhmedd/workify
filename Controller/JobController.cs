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
    public class JobController
    {
        public void AddJob(Model.Job job)
        {
            Jobs jbs = new Jobs();
            jbs.AddJob(job);
        }
        public void UpdateJob(Model.Job job)
        {
            Jobs jbs = new Jobs();
            jbs.UpdateJob(job);
        }
        public void DeleteJob(string jobId)
        {
            Jobs jbs = new Jobs();
            jbs.DeleteJob(jobId);
        }
        public void DeleteJobByJobCreator(string jobCreator)
        {
            Jobs jbs = new Jobs();
            jbs.DeleteJobByJobCreator(jobCreator);
        }
        public Job SearchJob(string jobId, string jobCreator)
        {
            Jobs jbs = new Jobs();
            Job jb = jbs.SearchJob(jobId, jobCreator);
            return jb;
        }
        public Job SearchJob(string jobId)
        {
            Jobs jbs = new Jobs();
            return jbs.SearchJob(jobId);
        }
        public List<Job> SearchJobByCreator(string jobCreator)
        {
            Jobs jbs = new Jobs();
            return jbs.SearchJobByCreator(jobCreator);
        }
        public List<Job> SearchJobByTitle(string jobTitle)
        {
            Jobs jbs = new Jobs();
            return jbs.SearchJobByTitle(jobTitle);
        }
        public Job ApplyJob(string jobId, string jobtitle)
        {
            Jobs jbs = new Jobs();
            return jbs.ApplyJob(jobId, jobtitle);
        }

        public List<Job> GetAllJobs()
        {
            Jobs jbs = new Jobs();
            return jbs.GetAllJobs();
        }
    }
}
