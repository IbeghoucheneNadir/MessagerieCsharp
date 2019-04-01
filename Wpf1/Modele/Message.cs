using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf1
{

    [Table("Message")]
    public class Message
    {
        [Column("ID")]
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [Column("TEXTMESSAGE")]
        public String message { get; set; }
        [Column("FROM")]
        public String from { get; set; }
        [Column("TO")]
        public String to { get; set; }
        [Column("DATEMESSAGE")]
        public DateTime dateMessage { get; set; }

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
