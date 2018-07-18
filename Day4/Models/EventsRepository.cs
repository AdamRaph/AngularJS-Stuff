using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day4.Models
{
    public class EventsRepository
    {
        public TalkVM[] GetTalks()
        {
            var talks = new[]
            {
                new TalkVM { Id= 1001, Name= "AngularJS 101", Speaker= "Adam Raphael", Venue= "Hall 2", Duration= "45m" },
                new TalkVM { Id= 1002, Name= "ASP.NET 101", Speaker= "Leigh Hogan", Venue= "Hall 1", Duration= "2h" },
                new TalkVM { Id= 1005, Name= "RMA 101", Speaker= "Jackson Collins", Venue= "Boardroom", Duration= "1h30m" },
                new TalkVM { Id= 1003, Name= "Cloud 101", Speaker= "Adam Raphael", Venue= "Hall 3", Duration= "30m" },
                new TalkVM { Id= 1004, Name= "IT HUB 101", Speaker= "Adam Raphael", Venue= "Hall 1", Duration= "20m" }
            };
            return talks;
        }
    }
}