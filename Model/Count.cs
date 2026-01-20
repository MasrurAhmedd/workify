using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class Count
    {
        private int countId = 1;
        private int objcount;
        

        public Count()
        {

        }

        public Count(int countId, int objcount)
        {
            this.CountId = countId;
            this.Objcount = objcount;
        }

        public int CountId { get => countId; set => countId = value; }
        public int Objcount { get => objcount; set => objcount = value; }
    }
}
