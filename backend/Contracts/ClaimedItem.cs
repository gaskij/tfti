using System;
using System.Collections.Generic;
using System.Text;

namespace TFTI.Contracts
{
    public class ClaimedItem
    {
      public string user_name { get; set; }
      public string item_name { get; set; }
      public int amount { get; set; }
      public string unit_type { get; set; }
    }
}
