using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TFTI.Contracts
{
    [Table("friends")]
    public class Friend
    {
        [Key]
        public int id_1 { get; set; }

        public int id_2 { get; set; }
    }
}
