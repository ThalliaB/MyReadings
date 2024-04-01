using Microsoft.AspNetCore.Mvc;
using MyReadings.Data;
using MyReadings.Models;

namespace MyReadings.Controllers
{
    public class MyReadingsController : Controller
    {

        readonly private ApplicationDbContext _db;

        public MyReadingsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<MyReadingsModel> myReadings = _db.MyReadings;
            return View(myReadings);
        }

        public IActionResult AddNewReading()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewReading(MyReadingsModel myreadings)
        {
            if(ModelState.IsValid)
            {
                _db.MyReadings.Add(myreadings);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        //public IActionResult OpenViewReading() { }
    }
}
