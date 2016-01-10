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

                ListFollower.Add(follower);
            }

            return ListFollower;
        }
    }
}
