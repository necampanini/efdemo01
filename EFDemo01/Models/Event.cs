using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo01.Models
{
    public class Event
    {
        //we mapped this class to the Events table in the 'EventsDbContext' class

        //as long as there is a property with 'Id' in it, entity framework will
        //assume this is the primary key -- we can change this, but thats whats happening
        //underneath the hood if we leave it as is
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
    }
}