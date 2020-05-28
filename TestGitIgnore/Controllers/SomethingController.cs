using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestGitIgnore.Controllers
{
    public class SomethingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}