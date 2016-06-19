using BUS.DAL_WS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeathcareFamilyBUS
{
    public class MessageBUS
    {
        HF_DAL_WebserviceSoapClient ws;

        public MessageBUS()
        {
            ws = new HF_DAL_WebserviceSoapClient();
        }
        // return: list message where username = receiver or username = sender
        public List<MessageDTO> GetListMessage(String username, String follower)
        {
            List<MessageDTO> list = new List<MessageDTO>(ws.GetListMessage(username, follower));
            if (list == null)
                return new List<MessageDTO>();
            return list;
        }
    }
}
