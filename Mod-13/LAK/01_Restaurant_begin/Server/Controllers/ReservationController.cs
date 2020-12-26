﻿using Microsoft.AspNetCore.Mvc;
using Server.Data;
using Server.Models;
using System.Linq;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private RestaurantContext _context;

        public ReservationController(RestaurantContext context)
        {
            _context = context;
        }

        [Route("{id:int}")]
        public ActionResult<OrderTable> GetById(int id)
        {
            var order = _context.ReservationsTables.FirstOrDefault(p => p.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        [HttpPost]
        public ActionResult<OrderTable> Create(OrderTable orderTable)
        {
            _context.Add(orderTable);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = orderTable.Id }, orderTable);
        }
    }
}
