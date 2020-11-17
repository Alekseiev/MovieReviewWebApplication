using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieReviewWebApplication.Models;


namespace MovieReviewWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }  
        
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        public ActionResult ListResponses()
        {
            return View(Repository.Responses.Where(guest => guest.WillAttend == true));
        }
    }
}
