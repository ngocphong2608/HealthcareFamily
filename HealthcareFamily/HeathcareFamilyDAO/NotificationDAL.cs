using HealthcareFamilyDAL;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyDAL
{
    public class NotificationDAL
    {
        public List<NotificationDTO> GetListNotification(string username)
        {
            String query = "SELECT * FROM NOTIFICATION WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<NotificationDTO> ListNoti = new List<NotificationDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                NotificationDTO noti = new NotificationDTO();
                noti.FollowerUsername = dr["FollowerInformation"].ToString();
                noti.Detail = dr["Detail"].ToString();
                noti.Time = DateTime.Parse(dr["Time"].ToString());
                ListNoti.Add(noti);
            }

            return ListNoti;
        }
    }
}
