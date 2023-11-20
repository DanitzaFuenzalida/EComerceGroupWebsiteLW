using ECommerceSite.Model;
using System;
using System.Collections.Generic;

namespace ECommerceSite.Pages
{
    public class OrderModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public Order SampleOrder { get; set; }

        public void OnGet() //This gets executed as soon as the page is called.
        {
            SampleOrder = new Order
            {
                OrderId = 1,
                OrderDate = DateTime.Now,
                UserId = "user123",
                OrderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        OrderItemId = 1, // Adding Sample Data (Hard-coded)
                        ProductId = 101,
                        Quantity = 2,
                        UnitPrice = 25.00m
                    },
                    new OrderItem
                    {
                        OrderItemId = 2, // Adding Sample Data (Hard-coded)
                        ProductId = 102,
                        Quantity = 1,
                        UnitPrice = 45.00m
                    }
                },
                TotalAmount = 95.00m, // Display Sum
                Status = OrderStatus.Pending
            };
        }
    }
}

