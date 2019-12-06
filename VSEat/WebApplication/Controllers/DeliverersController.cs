﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using DTO;

namespace WebApplication.Controllers
{
    public class DeliverersController : Controller
    {
        private IConfiguration Configuration { get; }

        public DeliverersController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            /*OrdersManager ordersManager = new OrdersManager(Configuration);
            int id = (int)HttpContext.Session.GetInt32("userid");
            List<Order> list = ordersManager.GetOrderByDelivererId(1);
            return View(list);*/
            return View();
        }

        public IActionResult MyDeliveries()
        {
            OrdersManager ordersManager = new OrdersManager(Configuration);
            int id = (int)HttpContext.Session.GetInt32("userid");
            List<Order> list = ordersManager.GetOrderByDelivererId(1);
            return View(list);
        }
    }
}