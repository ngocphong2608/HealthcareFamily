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
    public class UserInformationDAL
    {
        public UserInformation LoadUserInformation(String username)
        {
            String query = "SELECT * FROM USER_INFORMATION WHERE Username='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            UserInformation user = new UserInformation();

            user.mUsername = dr["Username"].ToString();
            user.mPassword = dr["Password"].ToString();
            user.mName = dr["Name"].ToString();
            user.mBirthday = DateTime.Parse(dr["Birthday"].ToString());
            user.mGender = dr["Gender"].ToString();
            user.mEmail = dr["Email"].ToString();
            //user.mAvatar = null;
            user.mAccountType = dr["AccountType"].ToString();

            return user;
        }
    }
}
