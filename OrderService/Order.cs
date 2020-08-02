using System;

namespace OrderService
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
