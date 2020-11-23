using System;
using System.Collections.Generic;
using System.Text;

namespace TFTI.Contracts
{
    public class Event
    {
        public string Name { get; set; }

        public User Host { get; set; }

        public IList<User> Guests { get; set; }

        public IList<Item> Items { get; set; }
    }
}
