﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using WebApplicationRRPortal.Models;

namespace WebApplicationRRPortal.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
          
            ViewBag.Message = "Your contact page.";
            return View();
        }


    }
}