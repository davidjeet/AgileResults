using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileResults.Web.Models;
using AgileResults.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace AgileResults.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            this._repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FakeContact(Person person)
        {
            var personId = await _repository.AddPerson(person);
            ModelState.Clear();
            ViewData["Message"] = $"Person {personId} was added.";
            return View("About");
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
