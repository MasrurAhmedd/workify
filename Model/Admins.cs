using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Online_Job_Management_System_Kamao.Model
{
    public class Admins:Admin
    {

        SqlDbDataAccess sda = new SqlDbDataAccess();

        public Admins() : base() { }

        public Admins(string adminId, string adminName, string adminPassword, string adminEmail) : base(adminId, adminName, adminPassword,adminEmail)
        {
            this.AdminId = adminId;
            this.AdminName = adminName;
            this.AdminPassword = adminPassword;
            this.AdminEmail = adminEmail;
        }
        
        public override void AddAdmin(Admin a)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Admin VALUES (@adminId, @adminName, @adminPassword, @role);");
            cmd.Parameters.AddWithValue("@adminId", a.AdminId);
            cmd.Parameters.AddWithValue("@adminName", a.AdminName);
            cmd.Parameters.AddWithValue("@adminPassword", a.AdminPassword);
            cmd.Parameters.AddWithValue("@role", a.Role);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public override void UpdateAdmin(Admin a)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Admin SET adminId=@adminId, adminName=@adminName, adminPassword=@adminPassword WHERE adminId = @adminId;");
            cmd.Parameters.AddWithValue("@adminId", a.AdminId);
            cmd.Parameters.AddWithValue("@adminName", a.AdminName);
            cmd.Parameters.AddWithValue("@adminPassword", a.AdminPassword);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public override void DeleteAdmin(string adminId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Admin WHERE adminId=@adminId;");
            cmd.Parameters.AddWithValue("@adminId", adminId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<Admin> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Admin> adminList = new List<Admin>();
            using (reader)
            {
                while (reader.Read())
                {
                    int rl;
                    Admin a = new Admins(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3));
                    adminList.Add(a);
                }
            }
            cmd.Connection.Close();
            return adminList;
        }
        public override Admin SearchAdmin(string adminId, string adminPassword)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Admin WHERE adminId=@adminId AND adminPassword=@adminPassword;");
            cmd.Parameters.AddWithValue("@adminId", adminId);
            cmd.Parameters.AddWithValue("@adminPassword", adminPassword);
            cmd.CommandType = CommandType.Text;
            List<Admin> admins = GetData(cmd);
            return admins.Count > 0 ? admins[0] : null;
        }
        public  List<Admin> GetAllAdmins()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Admin;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        } 

    } 
} 
