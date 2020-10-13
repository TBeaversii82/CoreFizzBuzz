using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreFizzBuzz.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CoreFizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Solve()
        {
            return View();

        }


        [HttpPost]
        public object Solve(string input1, string input2)
        {
            var userIn1 = Convert.ToInt32(input1);
            var userIn2 = Convert.ToInt32(input2);
            var output = new StringBuilder();
            for (int index = 1; index <= 100; index++)
            {
                output.AppendLine("");
                if (index % userIn1 == 0 && index % userIn2 == 0)
                {

                    output.AppendLine("FizzBuzz");

                }
                else if (index % userIn1 == 0)
                {
                    output.AppendLine("Fizz");
                }
                else if (index % userIn2 == 0)
                {
                    output.AppendLine("Buzz");

                }
                else
                {
                    output.AppendLine(index.ToString());
                }

            }
            ViewData["Output"] = output.ToString();
            return View();


           
        }


        public IActionResult Code()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}







