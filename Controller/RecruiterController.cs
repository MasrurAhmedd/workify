using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Job_Management_System_Kamao.Model;
using System.Data.SqlClient;
using System.Data;

namespace Online_Job_Management_System_Kamao.Controller
{
    public class RecruiterController
    {
        public void AddRecruiter(Recruiter r)
        {
            Recruiters recruiters = new Recruiters();
            recruiters.AddRecruiter(r);
        }
        public void UpdateRecruiter(Recruiter r)
        {
            Recruiters recruiters = new Recruiters();
            recruiters.UpdateRecruiter(r);
        }
        public void DeleteRecruiter(string recruiterId)
        {
            Recruiters recruiters = new Recruiters();
            recruiters.DeleteRecruiter(recruiterId);
        }
       public Recruiter SearchRecruiter(string recruiterId,string recruiterPassword)
        {
            Recruiters recruiters = new Recruiters();
            Recruiter r=recruiters.SearchRecruiter(recruiterId,recruiterPassword);
            return r;
        }

        public Recruiter SearchRecruiterEmail(string recruiterId,string recruiterEmail)
        {
            Recruiters recruiters = new Recruiters();
            Recruiter r = recruiters.SearchRecruiterEmail(recruiterId, recruiterEmail);
            return r;
        }
        public List<Recruiter> GetAllRecruiter()
        {
            Recruiters jss = new Recruiters();
            List<Recruiter> jsList = jss.GetAllRecruiter();
            return jsList;

        }
    }
}
