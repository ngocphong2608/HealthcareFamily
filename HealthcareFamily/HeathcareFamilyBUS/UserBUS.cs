using HealthcareFamilyDTO;
using HealthcareFamilyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyBUS
{
    public class UserBUS
    {
        UserDAL userDAL;
        AccountTypeDAL accoutTypeDAL;
        public UserBUS()
        {
            userDAL = new UserDAL();
            accoutTypeDAL = new AccountTypeDAL();
        }
        public UserDTO GetUserInformation(String username)
        { 
            return userDAL.GetUserInformation(username);
        }
        public bool SignIn(String username, String password)
        {
            return userDAL.SignIn(username, password);
        }
        public void SignOut(String username)
        {
            userDAL.SetStatus(username, false);
        }
        public bool SignUp(String username, String password, String name, DateTime birthday, String gender, String email, String accountType)
        {
            if (!userDAL.IsUserExisted(username) && userDAL.IsEmailExisted(email))
                return false;

            String AccountTypeCode = accoutTypeDAL.GetAccountTypeCode(accountType);
            // xu li ngoai le account type khong ton tai

            return userDAL.SignUp(username, password, name, birthday, gender, email, AccountTypeCode);
        }

        // username: username add follower
        // email: follower email
        public bool AddFollowerByEmail(String username, String email, String relationship)
        {
            UserDTO userDTO = userDAL.GetUserImformationByEmail(email);
            if (userDTO != null)
            {
                return userDAL.AddFollower(username, userDTO.Username, relationship);
            }
            return false;
        }

        // username: username add follower
        // email: follower email
        public bool DeleteFollowerByEmail(String username, String email)
        {
            UserDTO userDTO = userDAL.GetUserImformationByEmail(email);
            if (userDTO != null)
            {
                return userDAL.DeleteFollower(username, userDTO.Username);
            }
            return false;
        }

        // username: username add follower
        // email: follower email
        public bool AcceptFollowByEmail(String username, String email)
        {
            UserDTO userDTO = userDAL.GetUserImformationByEmail(email);
            if (userDTO != null)
            {
                return userDAL.AcceptFollow(username, userDTO.Username);
            }
            return false;
        }

        // username: username add follower
        // email: follower email
        public bool AllowAccessInfoByEmail(String username, String email)
        {
            UserDTO userDTO = userDAL.GetUserImformationByEmail(email);
            if (userDTO != null)
            {
                return userDAL.AllowAccess(username, userDTO.Username);
            }
            return false;
        }

        // username: username add follower
        // email: follower email
        public bool UnAllowAccessInfoByEmail(String username, String email)
        {
            UserDTO userDTO = userDAL.GetUserImformationByEmail(email);
            if (userDTO != null)
            {
                return userDAL.UnAllowAccess(username, userDTO.Username);
            }
            return false;
        }

        public bool IsEmailExisted(String email)
        {
            UserDAL user = new UserDAL();
            return user.IsEmailExisted(email);
        }
    }
}
