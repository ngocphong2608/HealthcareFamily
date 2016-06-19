using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeathcareFamilyDTO
{
    public class MessageDTO
    {
        public string Sender_Username { get; set; }
        public string Reciever_Username { get; set; }
        public DateTime Time { get; set; }
        public string Detail { get; set; }
    }
}
