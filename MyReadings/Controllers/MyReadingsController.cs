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
    }
}
