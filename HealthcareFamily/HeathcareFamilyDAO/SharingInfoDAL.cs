using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyDAL
{
    public class SharingInfoDAL
    {
        public SharingInfoDAL()
        {

        }
        public void UpdateSharingInfo(String username, String follower, bool share)
        {
            String query = "UPDATE SHARING_INFORMATION ";
            query += "SET IsPermitAccessInfo='" + Convert.ToString(share) + "' ";
            query += "WHERE Username='" + username + "' ";
            query += "AND FollowerUsername='" + follower + "'";

            try
            {
                DataProvider.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void SetSharingInfo(String username, String follower, bool share)
        {
            String query = "INSERT INTO SHARING_INFORMATION VALUES(";
            query += "'" + username + "', ";
            query += "'" + follower + "', ";
            query += "'" + Convert.ToString(share) + "')";

            try
            {
                DataProvider.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public SharingInfoDTO GetSharingInfo(String username, String follower)
        {
            String query = "SELECT * FROM SHARING_INFORMATION WHERE USERNAME='" + username + "' ";
            query += "AND FollowerUsername='" + follower + "'";

            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];

            SharingInfoDTO sharingDTO = new SharingInfoDTO();
            sharingDTO.FollowerUsername = dr["FollowerUsername"].ToString();
            sharingDTO.IsPermitAccessInfo = Boolean.Parse(dr["IsPermitAccessInfo"].ToString());
            sharingDTO.Username = dr["Username"].ToString();

            return sharingDTO;
        }
    }
}
