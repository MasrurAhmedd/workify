using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class JobApplication
    {
        private string jobApplicationId;
        private DateTime jobApplicationDate;
        private string jobSeekerId;
        private string jobSeekerEmail;
        private string jobSeekerSKill;
        private string jobId;
        private string jobTitle;
        private string jobCreator;
        public JobApplication()
        {
        }

        public JobApplication(string jobApplicationId, DateTime jobApplicationDate, string jobSeekerId, string jobSeekerEmail, string jobSeekerSKill, string jobId, string jobTitle, string jobCreator)
        {
            this.jobApplicationId = jobApplicationId;
            this.jobApplicationDate = jobApplicationDate;
            this.jobSeekerId = jobSeekerId;
            this.jobSeekerEmail = jobSeekerEmail;
            this.jobSeekerSKill = jobSeekerSKill;
            this.jobId = jobId;
            this.jobTitle = jobTitle;
            this.jobCreator = jobCreator;
        }

        public string JobApplicationId { get => jobApplicationId; set => jobApplicationId = value; }
        public DateTime JobApplicationDate { get => jobApplicationDate; set => jobApplicationDate = value; }
        public string JobSeekerId { get => jobSeekerId; set => jobSeekerId = value; }
        public string JobSeekerEmail { get => jobSeekerEmail; set => jobSeekerEmail = value; }
        public string JobSeekerSKill { get => jobSeekerSKill; set => jobSeekerSKill = value; }
        public string JobId { get => jobId; set => jobId = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public string JobCreator { get => jobCreator; set => jobCreator = value; }

    }
}
