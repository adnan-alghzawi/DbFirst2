using DbFirst2.Models;
using Microsoft.AspNetCore.Mvc;


namespace DbFirst2.Controllers
{
    public class UserController : Controller
    {
        private MyDbContext _context;
        public UserController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var users = _context.Users;
            return View(users);
        }
        public IActionResult Create()
        {
            return View();
        }

        // Add new user to database
        [HttpPost]
        public IActionResult Create(User user)
        {

            _context.Users.Add(user);
            _context.SaveChanges();
            return View(user);
        }
    }
}
