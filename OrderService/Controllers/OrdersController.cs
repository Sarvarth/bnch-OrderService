using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace OrderService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        // GET orders/5
        [HttpGet("{id}")]
        public ActionResult<List<Order>> Get(int id)
        {
            return new List<Order> {
                new Order {
                    OrderId = 1,
                    OrderAmount = 100,
                    OrderDate = Convert.ToDateTime("10-10-2020")
                },
                new Order
                {
                    OrderId = 2,
                    OrderAmount = 200,
                    OrderDate = Convert.ToDateTime("10/11/2019")
                }};
        }
    }
}
