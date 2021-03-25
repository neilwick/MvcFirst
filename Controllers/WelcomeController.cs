
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcFirst.Models;

namespace MvcFirst.Controllers
{
    public class WelcomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public WelcomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet=true)]
        public string Message { get; set; }

        public string Index()
        {
            return "hi!";
        }

        public string Bye()
        {
            return "bye!";
        }

        public IActionResult Greet(string message, int count= 1)
        {

            string msg = "";
            if (!string.IsNullOrEmpty(message)) {
                for (int i = 0; i < count; i++) {
                    msg += HtmlEncoder.Default.Encode(message) + "<br>";
                }

                ViewBag.msg = msg;

            } else {
                ViewBag.msg = "";
            }

            return View();
        }

    }
}
