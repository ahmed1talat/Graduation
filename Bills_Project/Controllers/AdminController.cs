using Bills_Project.Models;
using Bills_Project.services;
using Microsoft.AspNetCore.Mvc;

namespace Bills_Project.Controllers
{
    public class AdminController : Controller
    {
        private readonly IClintRepository clintRepository;

        public AdminController(IClintRepository clintRepository)
        {
            this.clintRepository = clintRepository;
        }
        // ------------------------------- clint --------------------------------------//
        public IActionResult Client()
        {
            return View();
        }
        public IActionResult SaveClient(Client newClient )
        {
           // newClient.Number = ((newClient.Id *2)+4).ToString();
            if (ModelState.IsValid == true)
            {
                clintRepository.Insert(newClient);
                return RedirectToAction("index");
            }
            else
            {
                return View("Client",newClient);
            }
        }
        // ---------custom validation for unique clint name ----------------//
        public IActionResult UniqueClintName(string ClintName)
        {
            var clintname = clintRepository.GetByName(ClintName);
            if (clintname == null)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        // --------------------------------------------------------------------------------------//
        public IActionResult CompanyData()
        {
            return View();
        }

        public IActionResult SalesInvoice()
        {
            return View();
        }
        public IActionResult SalesReport()
        {
            return View();
        }
        public IActionResult Types()
        {
            return View();
        }
        public IActionResult Units()
        {
            return View();
        }
        public IActionResult Categories() 
        {
            return View();
        }
        public IActionResult Species()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        

    }
}
