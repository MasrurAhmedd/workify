using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class JobSeeker
    {
        private string jobSeekerId;
        private string jobSeekerName;
        private string jobSeekerPassword;
        private string jobSeekerGender;
        private string jobSeekerEmail;
        private string jobSeekerSkill;
        private const int role=3;
        private const string adminId = "A-1";

        public string JobSeekerId { get => jobSeekerId; set => jobSeekerId = value; }
        public string JobSeekerName { get => jobSeekerName; set => jobSeekerName = value; }
        public string JobSeekerPassword { get => jobSeekerPassword; set => jobSeekerPassword = value; }
        public string JobSeekerGender { get => jobSeekerGender; set => jobSeekerGender = value; }
        public string JobSeekerEmail { get => jobSeekerEmail; set => jobSeekerEmail = value; }
        public string JobSeekerSkill { get => jobSeekerSkill; set => jobSeekerSkill = value; }

        public  int Role => role;

        public string AdminId => adminId;

        public JobSeeker()
        {
           
        }
        public JobSeeker(string jobSeekerId, string jobSeekerName, string jobSeekerPassword, string jobSeekerGender, string jobSeekerEmail, string jobSeekerSkill)
        {
            this.JobSeekerId = jobSeekerId;
            this.JobSeekerName = jobSeekerName;
            this.JobSeekerPassword = jobSeekerPassword;
            this.JobSeekerGender = jobSeekerGender;
            this.JobSeekerEmail = jobSeekerEmail;
            this.JobSeekerSkill = jobSeekerSkill;
        }
    }
}
