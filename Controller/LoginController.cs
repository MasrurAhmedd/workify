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
    public class LoginController
    {
        public void AddLogin(Login l)
        {
            Logins logins = new Logins();
            logins.AddLogin(l);
        }
        public void UpdateLogin(Login l)
        {
            Logins logins = new Logins();
            logins.UpdateLogin(l);
        }
        public void DeleteLogin(string loginId)
        {
            Logins logins = new Logins();
            logins.DeleteLogin(loginId);
        }
        public Login SearchLogin(string loginId, string loginPassword)
        {
            Logins logins = new Logins();
            Login l = logins.SearchLogin(loginId, loginPassword);
            return l;
        }
        public Login SearchLogin(string loginId)
        {
            Logins logins = new Logins();
            Login l = logins.SearchLogin(loginId);
            return l;
        }
        public List<Login> GetAllLogin()
        {
            Logins logins = new Logins();
            List<Login> loginList = logins.GetAllLogin();
            return loginList;
        }
    }
}
