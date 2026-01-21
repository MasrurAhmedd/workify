using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class Counts 
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void UpdateCount(Count c)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Count SET countId=countId,objcount=@objcount WHERE countId = @countId;");
            cmd.Parameters.AddWithValue("@countId", c.CountId);
            cmd.Parameters.AddWithValue("@objcount", c.Objcount);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Count> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Count> countList = new List<Count>();

            using (reader)
            {
                while (reader.Read())
                {
                    Count c = new Count();
                    c.CountId = reader.GetInt32(0);
                    c.Objcount = reader.GetInt32(1);

                    countList.Add(c);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return countList;
        }
        public Count SearchCount(int countId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Count WHERE countId=@countId ;");
            cmd.Parameters.AddWithValue("@countId", countId);
            cmd.CommandType = CommandType.Text;

            List<Count> countList = GetData(cmd);

            if (countList.Count > 0)
            {
                return countList[0];
            }

            else
            {
                return null;
            }
        }
    }
}
