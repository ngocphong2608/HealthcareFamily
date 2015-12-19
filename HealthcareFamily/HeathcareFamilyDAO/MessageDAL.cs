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
        public List<MessageDTO> GetListMessage(string username)
        {
            String query = "SELECT * FROM MESSAGE WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<MessageDTO> ListMessage = new List<MessageDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                MessageDTO message = new MessageDTO();
                message.Detail = dr["Detail"].ToString();
                message.FollowerUsername = dr["FollowerUsername"].ToString();
                message.Time = DateTime.Parse(dr["Time"].ToString());
                ListMessage.Add(message);
            }

            return ListMessage;
        }
    }
}
