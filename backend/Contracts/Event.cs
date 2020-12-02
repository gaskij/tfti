using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TFTI.Contracts
{
    [Table("events")]
    public class Event
    {
        public int event_id { get; set; }
        public string event_name { get; set; }
        public int host_id { get; set; }
        public string location { get; set; }
        public DateTime event_date { get; set; }
        public bool is_private { get; set; }
        public string event_summary { get; set; }
        public string addtional_links { get; set; }  
    }
}
