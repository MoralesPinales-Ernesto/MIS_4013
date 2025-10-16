using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace _P__MVC.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<string>
            {
                "Alice Johnson",
                "Bob Smith",
                "Charlie Lee",
                "Diana Prince",
                "Ethan Brown"
            };
            return View(students);
        }

        public IActionResult Events()
        {
            var events = new List<Event>
            {
                new Event { Name = "Career Fair", Date = DateTime.Parse("2025-10-20"), Location = "Main Hall" },
                new Event { Name = "Hackathon", Date = DateTime.Parse("2025-11-05"), Location = "Lab 101" },
                new Event { Name = "Guest Lecture", Date = DateTime.Parse("2025-10-25"), Location = "Auditorium" },
                new Event { Name = "Networking Night", Date = DateTime.Parse("2025-11-10"), Location = "Student Center" }
            };
            return View(events);
        }
    }

    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
    }
}
