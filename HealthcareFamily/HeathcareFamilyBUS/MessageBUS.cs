using HealthcareFamilyDAL;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyBUS
{
    public class MessageBUS
    {
        private MessageDAL mess;

        public MessageBUS()
        {
            mess = new MessageDAL();
        }
        // return: list message where username = receiver or username = sender
        public List<MessageDTO> GetListMessage(String username, String follower)
        {
            return mess.GetListMessage(username, follower);
        }
    }
}
