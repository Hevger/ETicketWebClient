﻿using ETicketWebClient.ETicketService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace ETicketWebClient.Controllers
{
    public class OrderController : Controller
    {
        ETicketService.OrderServiceClient orderClient = new ETicketService.OrderServiceClient();
        ETicketService.EventServiceClient eventClient = new ETicketService.EventServiceClient();


        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


      


        // GET: Order/Create
        [HttpPost]
        public ActionResult Create()
        {
            string UserId = User.Identity.GetUserId();
            int EventId = int.Parse(Request.Form["EventId"]);
            int quantity = int.Parse(Request.Form["quantity"]);

            Order order = new Order();
            order.Quantity = quantity;
            order.CustomerId = UserId;
            order.EventId = EventId;
            order.Date = DateTime.Now.Date;
            decimal ticketPrice = eventClient.GetEvent(EventId).TicketPrice;
            decimal totalPrice = ticketPrice * quantity;
            order.TotalPrice = totalPrice;

            var myOrder = orderClient.CreateOrder(order);
            return Content("Ok");
        }

        // POST: Order/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}