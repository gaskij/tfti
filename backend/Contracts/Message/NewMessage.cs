using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TFTI.Contracts
{
    public class NewMessage
    {
        public int sender_id { get; set; }
        public int recipient_id { get; set; }
        public DateTime message_time { get; set; }
        public string message { get; set; }
    }
}
