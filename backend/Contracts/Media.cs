using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TFTI.Contracts
{
    [Table("media")]
    public class Media
    {
        public int media_id { get; set; }
        [Required]
        public int event_id { get; set; }
        [Key]
        [Required]
        public int user_id { get; set; }
        public string file_path { get; set; }
        public string media_description { get; set; }
    }
}
