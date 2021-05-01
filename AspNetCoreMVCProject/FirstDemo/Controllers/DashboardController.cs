using FirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Summary()
        {
            var model = new SummaryModel();
            return View(model);
        }
    }
}
