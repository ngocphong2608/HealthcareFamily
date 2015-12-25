using HealthcareFamilyDAL;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyDAL
{
    public class MessageDAL
    {
        public List<MessageDTO> GetListMessage(string username, string follower)
        {
            String query = "SELECT * FROM MESSAGE WHERE (Sender_Username='" + username + "' AND Reciever_Username='" + follower + "') OR (Sender_Username='" + follower + "' AND Reciever_Username='" + username + "')";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<MessageDTO> ListMessage = new List<MessageDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                MessageDTO message = new MessageDTO();
                message.Detail = dr["Detail"].ToString();
                message.Reciever_Username = dr["Reciever_Username"].ToString();
                message.Time = DateTime.Parse(dr["Time"].ToString());
                message.Sender_Username = dr["Sender_Username"].ToString();
                ListMessage.Add(message);
            }

            return ListMessage;
        }
    }
}
