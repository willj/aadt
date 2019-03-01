﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace aadt.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}