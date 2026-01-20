using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class Recruiter
    {
        private string recruiterId;
        private string recruiterName;
        private string recruiterPassword;
        private string recruiterEmail;
        private string recruiterCompany;
        private const int role = 2;
        private const string adminId = "A-1";

        public Recruiter()
        {
        }
        public Recruiter(string recruiterId, string recruiterName, string recruiterPassword, string recruiterEmail, string recruiterCompany)
        {
            this.recruiterId = recruiterId;
            this.recruiterName = recruiterName;
            this.recruiterPassword = recruiterPassword;
            this.recruiterEmail = recruiterEmail;
            this.recruiterCompany = recruiterCompany;
        }

        public string RecruiterId { get => recruiterId; set => recruiterId = value; }
        public string RecruiterName { get => recruiterName; set => recruiterName = value; }
        public string RecruiterPassword { get => recruiterPassword; set => recruiterPassword = value; }
        public string RecruiterEmail { get => recruiterEmail; set => recruiterEmail = value; }
        public string RecruiterCompany { get => recruiterCompany; set => recruiterCompany = value; }

        public int Role => role;

        public string AdminId => adminId;
    }
}
