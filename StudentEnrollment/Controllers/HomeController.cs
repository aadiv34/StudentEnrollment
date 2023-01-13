using Microsoft.AspNetCore.Mvc;
using StudentEnrollment.Data;
using StudentEnrollment.Models;
using System.Diagnostics;

namespace StudentEnrollment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;
        public HomeController(ILogger<HomeController> logger,DataContext dataContext)
        {
            _logger = logger;
            _context = dataContext;
        }

        public IActionResult Index()
        {
            List<Country> cl = new List<Country>();
            cl = (from c in _context.country select c).ToList();
            cl.Insert(0, new Country { CId = 0, CountryName = "--Select Country Name--" });
            


            List<Subject> subjects = new List<Subject>();
            subjects = (from s in _context.subjects select s).ToList();
            subjects.Insert(0, new Subject { SId = 0, CourseName = "--Select Subject Name--" });
           
            Student slist = new Student();
            slist.countries.Add(cl);
            slist.subjects.Add(subjects);



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Country> GetCountries()
        {
            List<Country> result = new List<Country>();
            result = _context.country.ToList();
            return result;
        }
    }
}