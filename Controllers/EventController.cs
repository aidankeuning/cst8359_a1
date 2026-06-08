using CST8359_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CST8359_Assignment1.Controllers
{
    public class EventController : Controller
    {
        private static List<Event>? events = new()
            {
                new Event
                {
                    Id = 1,
                    Title = "Ottawa Jazz Festival",
                    Date  = new DateTime(2026, 7, 18),
                    Location = "Confederation Park",
                    Attendees = new List<Attendee>()
                },
                new Event
                {
                    Id = 2,
                    Title = "Farmer's Market",
                    Date = new DateTime(2026, 06, 20),
                    Location = "Main St",
                    Attendees = new List<Attendee>()
                }

            };
        public IActionResult Index()
        {
            return View(events);
        }

        public IActionResult ManageAttendees(int id)
        {
            var ev = events?.FirstOrDefault(e => e.Id == id);
            return View(ev);
        }
    }
}
