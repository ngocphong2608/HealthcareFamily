
using BUS.DAL_WS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HeathcareFamilyBUS
{
    public class NotificationBUS
    {
        HF_DAL_WebserviceSoapClient ws;

        public NotificationBUS()
        {
            ws = new HF_DAL_WebserviceSoapClient();
        }

        public List<NotificationDTO> GetListNotification(String username)
        {
            List<NotificationDTO> notiList = new List<NotificationDTO>(ws.GetListNotification(username));

            if (notiList == null)
                return new List<NotificationDTO>();

            notiList.Sort((x, y) => y.Time.CompareTo(x.Time));
            return notiList;
        }
        public void SetNotification(string username, string follower, DateTime dt, string detail)
        {
            string time = dt.ToShortDateString() + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;
            ws.SetNotification(follower, username, time, detail);
        }
    }
}
