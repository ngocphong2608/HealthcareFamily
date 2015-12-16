using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyDAL
{
    public class FollowerInformationDAL
    {
        public List<FollowerInformationDTO> GetListFollowerInformation(string username)
        {
            String query = "SELECT * FROM FOLLOWER_INFORMATION WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<FollowerInformationDTO> ListFollower = new List<FollowerInformationDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                FollowerInformationDTO follwer = new FollowerInformationDTO();
                follwer.FollowerUsername = dr["FollowerUsername"].ToString();
                follwer.IsPermitAccessInfo = Boolean.Parse(dr["IsPermitAccessInfo"].ToString());
                follwer.Relationship = dr["Relationship"].ToString();
                ListFollower.Add(follwer);
            }

            return ListFollower;
        }
    }
}
