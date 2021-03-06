﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
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

        public async Task<IActionResult> StationListAsync()
        {
            var stations = await ServiceRepository.Station();
            return View(stations);
        }

        public async Task<IActionResult> CardAsync()
        {
            var cards = await ServiceRepository.Station();
            var cardsBdx = await ServiceRepository.StationBdx();

            var ResultBdx = new List<Station>();
            foreach (var stationBdx in cardsBdx)
            {
                var construit = new Station(stationBdx);
                ResultBdx.Add(construit);
            }

            cards.AddRange(ResultBdx);

            return View(cards);
        }

        public IActionResult Favorite()
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
