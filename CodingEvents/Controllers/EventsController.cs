using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {

        public IActionResult Index()
        {
            List<Event> events = new List<Event>(EventData.GetAll());

            return View(events);
        }

       
        public IActionResult Add ()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)
            {
                Event newEvent = new Event
                {

                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail,
                    Location = addEventViewModel.Location,
                    Attendees = addEventViewModel.Attendees,
                };
                EventData.Add(newEvent);

                return Redirect("/Events");
            }

            return View(addEventViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach(int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }
            return Redirect("/Events");
        }

        [HttpPost]
        [Route("/Events/Edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            Event editingEvent = EventData.GetById(eventId);
            ViewBag.eventToEdit = editingEvent;
            ViewBag.title = "Edit Event" + editingEvent.Name + "(id = " + editingEvent.Id + ")";

            return View();
        }

        [HttpPost]
        [Route("/Events/Edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string descripton, string location, double attendees)
        {

            Event editngEvent = EventData.GetById(eventId);
            editngEvent.Name = name;
            editngEvent.Description = descripton;
            editngEvent.Location = location;
            editngEvent.Attendees = attendees;
                
            return Redirect("/Events");
        }
    }
}
