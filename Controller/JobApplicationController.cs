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
    public class JobApplicationController
    {
        public void AddJobApplication(JobApplication jobApplication)
        {
            JobApplications jas = new JobApplications();
            jas.AddJobApplication(jobApplication);
        }
        public void UpdateJobApplication(JobApplication jobApplication)
        {
            JobApplications jas = new JobApplications();
            jas.UpdateJobApplication(jobApplication);
        }
        public void DeleteJobApplication(string jobApplicationId)
        {
            JobApplications jas = new JobApplications();
            jas.DeleteJobApplication(jobApplicationId);
        }
        public void DeleteJobApplicationByJobId(string jobId)
        {
            JobApplications jas = new JobApplications();
            jas.DeleteJobApplicationByJobId(jobId);
        }
        public void DeleteJobApplicationByJobCreator(string jobCreator)
        {
            JobApplications jas = new JobApplications();
            jas.DeleteJobApplicationByJobCreator(jobCreator);
        }
        public void DeleteJobApplicationByJobSeekerId(string jobSeekerId)
        {
            JobApplications jas = new JobApplications();
            jas.DeleteJobApplicationByJobSeekerId(jobSeekerId);
        }
        public JobApplication CheckedApply(string jobId, string jobSeekerId)
        {
            JobApplications jas = new JobApplications();
            return jas.CheckedApply(jobId,jobSeekerId);
        }

        public List<Model.JobApplication> GetJobApplicationsByJobId(string jobId,string jobCreator)
        {
            JobApplications jas = new JobApplications();
            return jas.GetJobApplicationsByJobId(jobId, jobCreator);
        }

        public List<Model.JobApplication> GetJobApplicationsByJobSeekerId( string jobSeekerId)
        {
            JobApplications jas = new JobApplications();
            return jas.GetJobApplicationsByJobSeekerId(jobSeekerId);
        }
        public List<Model.JobApplication> GetJobApplicationsByJobCreator(string jobCreator)
        {
            JobApplications jas = new JobApplications();
            return jas.GetJobApplicationsByJobCreator(jobCreator);
        }
        public List<Model.JobApplication> GetAllJobApplications()
        {
            JobApplications jas = new JobApplications();
            return jas.GetAllJobApplications();
        }
        public List<Model.JobApplication> GetJobApplications(System.Data.SqlClient.SqlCommand cmd)
        {
            JobApplications jas = new JobApplications();
            return jas.GetJobApplications(cmd);
        }
    }
}
