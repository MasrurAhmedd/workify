using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class Job
    {
        private string jobId;
        private string jobTitle;
        private float jobSalary;
        private string jobDescription;
        private DateTime jobPostDate;
        private DateTime jobDeadline;
        private string jobCreator;

        public Job()
        {

        }
        public Job(string jobId, string jobTitle, float jobSalary, string jobDescription, DateTime jobPostDate, DateTime jobDeadline, string jobCreator)
        {
            this.JobId = jobId;
            this.JobTitle = jobTitle;
            this.JobSalary = jobSalary;
            this.JobDescription = jobDescription;
            this.JobPostDate = jobPostDate;
            this.JobDeadline = jobDeadline;
            this.JobCreator = jobCreator;
        }

        public string JobId { get => jobId; set => jobId = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public float JobSalary { get => jobSalary; set => jobSalary = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public DateTime JobPostDate { get => jobPostDate; set => jobPostDate = value; }
        public DateTime JobDeadline { get => jobDeadline; set => jobDeadline = value; }
        public string JobCreator { get => jobCreator; set => jobCreator = value; }
    }
}
