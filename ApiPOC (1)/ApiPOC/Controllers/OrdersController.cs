using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPOC.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }

    }

    
    public class Order
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
        public Boolean HasAccess { get; set; }

        public static List<Order> CreateOrders()
        {
            List<Order> OrderList = new List<Order>
            {
                new Order {UserID = 10248, UserName = "testId1", Location = "philadelphia", HasAccess = true },
                new Order {UserID = 10249, UserName = "Anonymous", Location = "Lowa", HasAccess = false},
                new Order {UserID = 10250,UserName = "testId2", Location = "Key Stone", HasAccess = false },
                new Order {UserID = 10251,UserName = "testId3", Location = "philadelphia", HasAccess = false},
                new Order {UserID = 10252,UserName = "testId4", Location = "DC", HasAccess = true}
            };

            return OrderList;
        }
    }

}
