﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstREST.IP
{
    public class LocalhostIP : Controller
    {
        //
        // GET: /LocalhostIP/

        public ActionResult Index()
        {
            return View();
        }

        public static String localhostIP()
        {
            return "http://localhost:3000";
            //return "http://localhost:49197";
        }

    }
}
