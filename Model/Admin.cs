using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public abstract class Admin
    {
        private string adminId;
        private string adminName;
        private string adminPassword;
        private string adminEmail;
        private  const int role = 1;

        public string AdminId { get => adminId; set => adminId = value; }
        public string AdminName { get => adminName; set => adminName = value; }
        public string AdminPassword { get => adminPassword; set => adminPassword = value; }
        public string AdminEmail { get => adminEmail; set => adminEmail = value; }

        public  int Role => role; 

        public Admin() { }

        public Admin(string adminId, string adminName, string adminPassword, string adminEmail)
        {
            this.AdminId = adminId;
            this.AdminName = adminName;
            this.AdminPassword = adminPassword;
            this.AdminEmail = adminEmail;
        }
        public abstract void AddAdmin(Admin a);
        public abstract void UpdateAdmin(Admin a);
        public abstract void DeleteAdmin(string adminId);
        public abstract Admin SearchAdmin(string adminId, string adminPassword);
         
    }
}
