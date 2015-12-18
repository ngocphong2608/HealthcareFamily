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
    public class UserDAL
    {
        public UserDTO GetUserInformation(String username)
        {
            String query = "SELECT * FROM USER_INFORMATION WHERE Username='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            UserDTO user = new UserDTO();

            user.Username = dr["Username"].ToString();
            user.Password = dr["Password"].ToString();
            user.Name = dr["Name"].ToString();
            user.Birthday = DateTime.Parse(dr["Birthday"].ToString());
            user.Gender = dr["Gender"].ToString();
            user.Email = dr["Email"].ToString();
            //user.mAvatar = null;
            user.AccountType = dr["AccountType"].ToString();

            return user;
        }
        public UserDTO SignIn(String username, String password)
        {
            String query = "SELECT * FROM USER_INFORMATION WHERE Username='" + username + "' AND Password='" + password + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            UserDTO user = new UserDTO();

            user.Username = dr["Username"].ToString();
            user.Password = dr["Password"].ToString();
            user.Name = dr["Name"].ToString();
            user.Birthday = DateTime.Parse(dr["Birthday"].ToString());
            user.Gender = dr["Gender"].ToString();
            user.Email = dr["Email"].ToString();
            //user.mAvatar = null;
            user.AccountType = dr["AccountType"].ToString();

            return user;
        }
    }
}
