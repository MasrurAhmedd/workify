using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Online_Job_Management_System_Kamao.Model;


namespace Online_Job_Management_System_Kamao.Controller
{
    public class AdminController
    {
        public void AddAdmin(Admin a)
        {
            Admins admins = new Admins();
            admins.AddAdmin(a);
        }
        public void UpdateAdmin(Admin a)
        {
            Admins admins = new Admins();
            admins.UpdateAdmin(a);
        }
        public void DeleteAdmin(string adminId)
        {
            Admins admins = new Admins();
            admins.DeleteAdmin(adminId);
        }

        public Admin SearchAdmin(string adminId,string adminPassword) 
        {
            Admins admins = new Admins();
            Admin admin = admins.SearchAdmin(adminId,adminPassword);
            return admin;
        }
        public List<Admin> GetAllAdmins()
        {
            Admins  ads = new Admins();
            List<Admin> adminList = ads.GetAllAdmins();
            return adminList;
        }

    }
}
