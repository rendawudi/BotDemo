﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BotWebChat.Controllers
{
    public class BotController : Controller
    {
        // GET: Bot
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Email()
        {
            return View();
        }
    }
}