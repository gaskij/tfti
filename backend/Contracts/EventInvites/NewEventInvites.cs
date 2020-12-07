using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TFTI.Contracts
{

    public class NewEventInvites
    {
        [Required]
        public int event_id { get; set; }
        public bool accepted { get; set; }
        public int recipient_id { get; set; }
        public int sender_id { get; set; }
        public DateTime invite_time { get; set; }
    }
}
