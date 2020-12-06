using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TFTI.Contracts
{
    [Table("users")]
    public class User
    {
        [Key]
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "first_name")]
        public string first_name { get; set; }

        [Display(Name = "last_name")]
        public string last_name { get; set; }

        [Display(Name = "email")]
        public string email { get; set; }

        [Display(Name = "pass_hash")]
        public string pass_hash { get; set; }

        [Display(Name = "salt")]
        public string salt { get; set; }

        [Display(Name = "phone_number")]
        public string phone_number { get; set; }

        [Display(Name = "user_summary")]
        public string user_summary { get; set; }
    }
}
