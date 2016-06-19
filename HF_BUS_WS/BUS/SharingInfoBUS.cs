using BUS.DAL_WS;
using HealthcareFamilyBUS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HeathcareFamilyBUS
{
    public class SharingInfoBUS
    {
        HF_DAL_WebserviceSoapClient ws;
        public SharingInfoBUS()
        {
            ws = new HF_DAL_WebserviceSoapClient();
        }
        public SharingInfoDTO GetSharingInfo(String username, String follower)
        {
            return ws.GetSharingInfo(username, follower);
        }
        public void UpdateSharingInfo(String username, String follower, bool share)
        {
            ws.UpdateSharingInfo(username, follower, share);
        }
        public void SetSharingInfo(String username, String follower, bool share)
        {
            ws.SetSharingInfo(username, follower, share);
        }

        public void SetSharingInfoByEmail(string username, string email, bool share)
        {
            UserBUS userBUS = new UserBUS();
            UserDTO follower = userBUS.GetUserInformationByEmail(email);

            ws.SetSharingInfo(username, follower.Username, share);
            ws.SetSharingInfo(follower.Username, username, share);
        }
    }
}
