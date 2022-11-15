using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YlvasKaffelager.Controllers
{
    public class CoffeeController : Controller
    {
        public IActionResult MyPage()
        {
            return View();
        }
    }
}
