using Online_Job_Management_System_Kamao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Controller
{
    public class CountController
    {    
        public void UpdateCount(Count c)
        {
            Counts cnts = new Counts();
            cnts.UpdateCount(c);
        }
        public Count SearchCount(int countId)
        {
            Counts cnts = new Counts();
            Count c=cnts.SearchCount(countId);
            return c;

        }
    }
}
