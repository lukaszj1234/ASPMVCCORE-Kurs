using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursASPMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace KursASPMVC.Controllers
{
    [Route("[controller]/[action]")]
    public class OrderController : Controller
    {
        public ViewResult Checkout()
        {
            return View(new Order());
        }
    }
}
