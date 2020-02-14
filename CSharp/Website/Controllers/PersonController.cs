using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Website.Models;
using Website.StaticData;

namespace Website.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }
        public IActionResult Details(int? id)
        {
            List<Person> ex = new List<Person>();
            if (!id.HasValue)
                return NotFound();

            var person = PersonData.People.FirstOrDefault(p => p.Id == id.Value);

            if (person == null)
                return NotFound();
            return View(person);
        }
    }
}