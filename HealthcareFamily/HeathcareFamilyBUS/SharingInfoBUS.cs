using HealthcareFamilyDAL;
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
        public void SetSharingInfo(String username, String follower, bool share)
        {
            sharingDAL.SetSharingInfo(username, follower, share);
        }
    }
}
