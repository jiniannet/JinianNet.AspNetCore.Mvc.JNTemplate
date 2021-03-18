﻿using JntemplateViewEngineDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JntemplateViewEngineDemo.Controllers
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
            this.Set("Site", new SiteViewModel
            {
                Name = "Jntemplate",
                Version = JinianNet.JNTemplate.Engine.Version
            });
            this.Set("Now", DateTime.Now);
            return View();
        }
    }
}
