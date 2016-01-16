using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyDAL
{
    public class FollowerDAL
    {
        public bool AddFollower(String username, String follower, String relationship)
        {
            String query = "INSERT INTO FOLLOWER_INFORMATION VALUES(";
            query += "'" + username + "',";
            query += "'" + follower + "',";
            query += Convert.ToString(0) + ",";
            query += "'" + relationship + "',";
            query += Convert.ToString(0) + ")";

            try
            {
                DataProvider.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<FollowerDTO> GetListFollower(string username)
        {
            String query = "SELECT * FROM FOLLOWER_INFORMATION WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<FollowerDTO> ListFollower = new List<FollowerDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                FollowerDTO follower = new FollowerDTO();
                follower.FollowerUsername = dr["Follower_Username"].ToString();
                follower.IsPermitAccessInfo = Boolean.Parse(dr["IsPermitAccessInfo"].ToString());
                follower.IsUserAccepted = Boolean.Parse(dr["IsUserAccepted"].ToString());
                follower.Relationship = dr["Relationship"].ToString();
                follower.Username = dr["Username"].ToString();
                ListFollower.Add(follower);
            }

            return ListFollower;
        }
    }
}
