﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeknoMuhendislikWebSite.Controllers
{
    public class HizmetlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
