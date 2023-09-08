using HotelSystemReview.Data;
using Microsoft.AspNetCore.Mvc;
using MusicSystemReview.Models;

namespace HotelSystemReview.Controllers
{
    public class ScratchClientsController : Controller
    {
        private HotelSystemReviewContext _context;
        public ScratchClientsController(HotelSystemReviewContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Client.ToList());
        }

        // Create GET
        public IActionResult Create()
        {
            return View();
        }

        // Create POST
        [HttpPost]
        public IActionResult Create([Bind("FirstName, LastName, PhoneNumber")] Client client)
        {
            ModelState.ClearValidationState(nameof(client.FirstName));
            client.FirstName = "Human";

            if(TryValidateModel(client))
            {
                _context.Client.Add(client);
                _context.SaveChanges();
            }
                return RedirectToAction("Index");
        }
    }
}
