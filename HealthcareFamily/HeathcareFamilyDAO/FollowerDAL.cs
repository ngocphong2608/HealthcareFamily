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
        public List<FollowerDTO> GetListFollowerInformation(string username)
        {
            String query = "SELECT * FROM FOLLOWER_INFORMATION WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<FollowerDTO> ListFollower = new List<FollowerDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                FollowerDTO follwer = new FollowerDTO();
                follwer.FollowerUsername = dr["FollowerUsername"].ToString();
                follwer.IsPermitAccessInfo = Boolean.Parse(dr["IsPermitAccessInfo"].ToString());
                follwer.Relationship = dr["Relationship"].ToString();
                ListFollower.Add(follwer);
            }

            return ListFollower;
        }
    }
}
