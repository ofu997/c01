using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCwithAuth.Models;
using System.Text.Encodings.Web;

namespace MVCwithAuth.Controllers
{
    public class ListResourcesController : Controller
    {
        public IActionResult Index()
        {
            // ViewData["Title"] = "Index";
            return View();
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}