using System;
using System.Collections.Generic;
using System.Text;

namespace TFTI.Contracts
{
    /// <summary>
    ///     Aggregate object to get the complete
    ///     details of an event.
    /// </summary>
    public class CompleteEvent
    {
        public Event EventDetails { get; set; }

        public IList<User> Guests { get; set; }

        public IList<ClaimedItem> ClaimedItems { get; set; }
        //public IList<EventAttendees> Attendees { get; set; }
        //public IList<Item> Items { get; set; }
    }
}
