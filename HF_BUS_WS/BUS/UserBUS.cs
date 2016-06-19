
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeathcareFamilyBUS;
using BUS.DAL_WS;

namespace HealthcareFamilyBUS
{
    public class UserBUS
    {
        HF_DAL_WebserviceSoapClient ws;
        public UserBUS()
        {
            
            ws = new HF_DAL_WebserviceSoapClient();
        }
        public UserDTO GetUserInformation(String username)
        {
            return ws.GetUserInformation(username);
        }
        public UserDTO GetUserInformationByEmail(String email)
        {
            return ws.GetUserInformationByEmail(email);
        }
        public bool SignIn(String username, String password)
        {
            UserDTO user = ws.GetUserInformation(username);

            if (user != null)
            {
                if (user.Password == password)
                {
                    ws.SetStatus(username, true);
                    return true;
                }
            }
            return false;
        }
        public void SignOut(String username)
        {
            ws.SetStatus(username, false);
        }
        public bool SignUp(String username, String password, String name, DateTime birthday, String gender, String email, String accountType)
        {
            if (!ws.IsUserExisted(username) && ws.IsEmailExisted(email))
                return false;

            String AccountTypeCode = ws.GetAccountTypeCode(accountType);
            // xu li ngoai le account type khong ton tai

            return ws.SignUp(username, password, name, birthday, gender, email, AccountTypeCode);
        }

        // username: username add follower
        // email: follower email
        public bool AllowAccessInfoByEmail(String username, String email)
        {
            UserDTO userDTO = ws.GetUserInformationByEmail(email);
            if (userDTO != null)
            {
                return ws.AllowAccess(username, userDTO.Username);
            }
            return false;
        }

        // username: username add follower
        // email: follower email
        public bool UnAllowAccessInfoByEmail(String username, String email)
        {
            UserDTO userDTO = ws.GetUserInformationByEmail(email);
            if (userDTO != null)
            {
                return ws.UnAllowAccess(username, userDTO.Username);
            }
            return false;
        }

        public bool IsEmailExisted(String email)
        {
            
            return ws.IsEmailExisted(email);
        }

        public List<UserDTO> GetListUserNotFriend(string username, string info)
        {
            List<UserDTO> list = new List<UserDTO>(ws.GetListUser(info));

            if (list == null)
                return new List<UserDTO>();

            FollowerBUS followerBUS = new FollowerBUS();
            List<FollowerDTO> followerList = followerBUS.GetAllFollower(username);

            List<UserDTO> remove = new List<UserDTO>();

            foreach (UserDTO user in list)
            {
                if (user.Username == username)
                {
                    remove.Add(user);
                    continue;
                }

                for (int i = 0; i < followerList.Count; i++)
                {
                    if (user.Username == followerList[i].FollowerUsername)
                    {
                        remove.Add(user);
                    }
                }
            }

            for (int i = 0; i < remove.Count; i++)
            {
                list.Remove(remove[i]);
            }

            return list;
        }
        public void UpdateAvatar(string username, byte[] img)
        {
            ws.UpdateAvatar(username, img);
        }
    }
}
