using HealthcareFamilyBUS;
using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyBUS
{
    public class SharingInfoBUS
    {
        SharingInfoDAL sharingDAL;
        public SharingInfoBUS()
        {
            sharingDAL = new SharingInfoDAL();
        }
        public SharingInfoDTO GetSharingInfo(String username, String follower)
        {
            return sharingDAL.GetSharingInfo(username, follower);
        }
        public void UpdateSharingInfo(String username, String follower, bool share)
        {
            sharingDAL.UpdateSharingInfo(username, follower, share);
        }
        public void SetSharingInfo(String username, String follower, bool share)
        {
            sharingDAL.SetSharingInfo(username, follower, share);
        }

        public void SetSharingInfoByEmail(string username, string email, bool share)
        {
            UserBUS userBUS = new UserBUS();
            UserDTO follower = userBUS.GetUserInformationByEmail(email);

            sharingDAL.SetSharingInfo(username, follower.Username, share);
            sharingDAL.SetSharingInfo(follower.Username, username, share);
        }
    }
}
