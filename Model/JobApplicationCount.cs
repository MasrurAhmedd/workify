using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class JobApplicationCount
    {
        private int jobApplicationCountId;
        private int jobApplicationObjCount;

        public JobApplicationCount() { }

        public JobApplicationCount(int jobApplicationCountId, int jobApplicationObjCount)
        {
            this.JobApplicationCountId = jobApplicationCountId;
            this.JobApplicationObjCount = jobApplicationObjCount;
        }

        public int JobApplicationCountId { get => jobApplicationCountId; set => jobApplicationCountId = value; }
        public int JobApplicationObjCount { get => jobApplicationObjCount; set => jobApplicationObjCount = value; }
    }
}
