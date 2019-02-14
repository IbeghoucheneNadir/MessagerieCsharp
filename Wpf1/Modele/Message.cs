using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf1
{
    public class Message
    {
        public int id;
        public String message;
        public String from;
        public String to;
        public DateTime dateMessage;

        public Message(int v1, string v2, string v3, string v4, string v5)
        {
        }

        public Message(int idMessage, String message, String from, String to, DateTime dateMessage)
        {
            id = idMessage;
            this.message = message;
            this.to = to;
            this.from = from;
            this.dateMessage = dateMessage;

        }

        public override string ToString()
        {
            return "Message " + id + " " + message + " " + from + " " + to + " " + dateMessage;
        }
    }
}
