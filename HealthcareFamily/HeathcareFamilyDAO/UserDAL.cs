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
            user.IsOnline = Boolean.Parse(dr["IsOnline"].ToString());

            return user;
        }
        public void SetStatus(String username, bool IsOnline)
        {
            String query = "UPDATE TABLE USER_INFORMATION";
            query += "SET IsOnline=" + Convert.ToString(IsOnline);
            query += "WHERE Username=" + username;

            try
            {
                DataProvider.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool SignIn(String username, String password)
        {
            String query = "SELECT * FROM USER_INFORMATION WHERE Username='" + username + "' AND Password='" + password + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return false;

            SetStatus(username, true);
            return true;
        }
        public void SignOut(String username)
        {
            SetStatus(username, false);
        }
        public bool IsUserExisted(string username)
        {
            String query = "SELECT * FROM USER_INFORMATION WHERE Username='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return false;

            return true;
        }
        public bool IsEmailExisted(string email)
        {
            String query = "SELECT * FROM USER_INFORMATION WHERE Email='" + email + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return false;

            return true;
        }
        public bool SignUp(String username, String password, String name, DateTime birthday, string gender, String email, String accountType)
        {
            String query = "INSERT INTO USER_INFORMATION VALUES=(";
            query += "'" + username + "',";
            query += "'" + password + "',";
            query += "'" + name + "',";
            query += "'" + birthday.ToString() + "',";
            query += "'" + gender + "',";
            query += "'" + email + "',";
            query += "'" + accountType + "')";
            // IsOnline
            try
            {
                DataProvider.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }
        public UserDTO GetUserImformationByEmail(String email)
        {
            String query = "SELECT * FROM USER_INFORMATION WHERE Email='" + email + "'";
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

        public bool AddFollower(String username, String follower, String relationship)
        {
            String query = "INSERT INTO FOLLOWER_INFORMATION VALUES=(";
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

        public bool DeleteFollower(String username, String follower)
        {
            String query = "DELETE FROM FOLLOWER_INFORMATION WHERE Username=";
            query += "'" + username + "'";
            query += "and";
            query += "Follower_Username='" + follower + "'";

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

        public bool AcceptFollow(String username, String follower)
        {
            String query = "UPDATE TABLE FOLLOWER_INFORMATION";
            query += "SET IsUserAccepted=1";
            query += "WHERE Username=";
            query += "'" + username + "'";
            query += "AND";
            query += "Follower_Username='" + follower + "'";

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

        public bool AllowAccess(String username, String follower)
        {
            String query = "UPDATE TABLE FOLLOWER_INFORMATION";
            query += "SET IsPermitAccessInfo=1";
            query += "WHERE Username=";
            query += "'" + username + "'";
            query += "AND";
            query += "Follower_Username='" + follower + "'";

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
    }
}

