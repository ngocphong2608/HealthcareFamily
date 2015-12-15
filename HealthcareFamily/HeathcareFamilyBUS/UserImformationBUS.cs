using HealthcareFamilyDTO;
using HeathcareFamilyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyBUS
{
    public class UserImformationBUS
    {
        public UserInformation LoadUserInformation(String username)
        { 
            UserInformationDAL user = new UserInformationDAL();
            return user.LoadUserInformation(username);
        }
    }
}
