using ITR_File.Data;
using Microsoft.AspNetCore.Mvc;

namespace ITR_File.Controllers
{
    public class ITRController : Controller
    {
        private readonly ITRDbContext _db;

        public ITRController(ITRDbContext db)

        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(string PANNumber)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(string PANNumber ) 
        {
            //var form= _db.
            return View();
        }
    }
}
