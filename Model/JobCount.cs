using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class JobCount
    {
        private int jobCountId;
        private int jobCountObj;

        public JobCount(int jobCountId, int jobCountObj)
        {
            this.jobCountId = jobCountId;
            this.jobCountObj = jobCountObj;
        }

        public int JobCountId { get => jobCountId; set => jobCountId = value; }
        public int JobCountObj { get => jobCountObj; set => jobCountObj = value; }
    }
}
