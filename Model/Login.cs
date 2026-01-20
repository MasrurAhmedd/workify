using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class Login
    {
        private string loginId;
        private string loginPassword;
        private int role;

        public Login()
        {
        }
        public Login(string loginId, string loginPassword, int role)
        {
            this.LoginId = loginId;
            this.LoginPassword = loginPassword;
            this.Role = role;
        }

        public string LoginId { get => loginId; set => loginId = value; }
        public string LoginPassword { get => loginPassword; set => loginPassword = value; }
        public int Role { get => role; set => role = value; }
    }
}
