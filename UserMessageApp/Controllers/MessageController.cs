﻿using Microsoft.AspNetCore.Mvc;

namespace UserMessageApp.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}