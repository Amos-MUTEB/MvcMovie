using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;


namespace MvcMovie.Controllers
{
    public class ApiController : Controller
    {

        public IActionResult StationList()
        {
            return View();
        }

    }
}