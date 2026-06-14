using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinChat
{
    [Serializable]
    public class clsMessage
    {
        public string Sender { get; set; }
        public string Message { get; set; }

        public clsMessage()
        {
            
        }

        public clsMessage(string Sender, string Message)
        {
            this.Sender = Sender;
            this.Message = Message;
        }
    }
}
