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
        public UserBUS()
        {
            userDAL = new UserDAL();
        }
        public UserDTO GetUserInformation(String username)
        { 
            return userDAL.GetUserInformation(username);
        }
        public UserDTO SignIn(String username, String password)
        {
            return userDAL.SignIn(username, password);
        }
    }
}
