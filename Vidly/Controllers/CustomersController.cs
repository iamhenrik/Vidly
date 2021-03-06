﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                 new Customer { Name = "customer 1"},
                 new Customer { Name = "customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            { 
                Customers = customers
            };

            return View(viewModel);
        }
    }
}