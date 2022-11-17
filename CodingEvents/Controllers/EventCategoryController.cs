using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodingEvents.Controllers
{

    public class EventCategoryController : Controller
    {
        private EventDbContext context;
        public EventCategoryController(EventDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.title = "All Categories";
            List<EventCategory> categories = context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        [Route("EventCategory/Create")]
        public IActionResult Create()
        {
            ViewBag.title = "Create";
            AddEventCategoryViewModel addEventCategoryViewModel = new AddEventCategoryViewModel();

            return View(addEventCategoryViewModel);
        }

        [HttpPost]
        public IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel addEventCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory newEventCategory = new EventCategory
                {

                    Name = addEventCategoryViewModel.Name,
                  
                };
                //EventData.Add(newEvent);
                context.Categories.Add(newEventCategory);
                context.SaveChanges();

                return Redirect("EventCategory");
            }

            return View(addEventCategoryViewModel);
        }

    }
}
