using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TFTI.Contracts
{
    [Table("event_invites")]
    public class EventInvites
    {
        [Key]
        public int event_invite_id { get; set; }
        [Required]
        public int event_id { get; set; }
        public bool accepted { get; set; }
        public int recipient_id { get; set; }
        public int sender_id { get; set; }
        public DateTime invite_time { get; set; }
    }
}
