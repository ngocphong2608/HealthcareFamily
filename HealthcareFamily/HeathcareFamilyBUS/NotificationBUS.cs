using HealthcareFamilyDAL;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyBUS
{
    public class NotificationBUS
    {
        NotificationDAL noti;

        public NotificationBUS()
        {
            noti = new NotificationDAL();
        }

        public List<NotificationDTO> GetListNotification(String username)
        {
            List<NotificationDTO> notiList = noti.GetListNotification(username);

            if (notiList == null)
                return new List<NotificationDTO>();

            notiList.Sort((x, y) => y.Time.CompareTo(x.Time));
            return notiList;
        }
        public void SetNotification(string username, string follower, DateTime dt, string detail)
        {
            string time = dt.ToShortDateString() + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;
            noti.SetNotification(follower, username, time, detail);
        }
    }
}
