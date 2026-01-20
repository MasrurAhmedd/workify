using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Online_Job_Management_System_Kamao.Model
{
    public class Logins
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddLogin(Login l)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Login VALUES (@loginId, @loginPassword, @role);");
            cmd.Parameters.AddWithValue("@loginId", l.LoginId);
            cmd.Parameters.AddWithValue("@loginPassword", l.LoginPassword);
            cmd.Parameters.AddWithValue("@role", l.Role);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateLogin(Login l)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Login SET loginId=@loginId, loginPassword=@loginPassword, role=@role WHERE loginId = @loginId;");
            cmd.Parameters.AddWithValue("@loginId", l.LoginId);
            cmd.Parameters.AddWithValue("@loginPassword", l.LoginPassword);
            cmd.Parameters.AddWithValue("@role", l.Role);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void DeleteLogin(string loginId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Login WHERE loginId=@loginId;");
            cmd.Parameters.AddWithValue("@loginId", loginId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<Login> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Login> loginList = new List<Login>();
            using (reader)
            {
                while (reader.Read())
                {
                    Login l = new Login();
                    l.LoginId = reader.GetString(0);
                    l.LoginPassword = reader.GetString(1);
                    l.Role = reader.GetInt32(2);
                     loginList.Add(l);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return loginList;
        }

        public Login SearchLogin(string loginId, string loginPassword)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Login WHERE loginId=@loginId AND loginPassword=@loginPassword;");
            cmd.Parameters.AddWithValue("@loginId", loginId);
            cmd.Parameters.AddWithValue("@loginPassword", loginPassword);
            cmd.CommandType = CommandType.Text;

            List<Login> loginList = GetData(cmd);

            if (loginList.Count > 0)
            {
                return loginList[0];
            }

            else
            {
                return null;
            }
        }
        public Login SearchLogin(string loginId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Login WHERE loginId=@loginId ;");
            cmd.Parameters.AddWithValue("@loginId", loginId);
            cmd.CommandType = CommandType.Text;
            List<Login> loginList = GetData(cmd);
            if (loginList.Count > 0)
            {
                return loginList[0];
            }
            else
            {
                return null;
            }
        }
        public List<Login> GetAllLogin()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Login;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }

    }
}
