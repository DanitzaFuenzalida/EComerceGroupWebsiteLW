using ECommerceSite.Data;
using ECommerceSite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ECommerceSite.Pages
{
    public class OrderModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ApplicationDbContext _context;

        public OrderModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }
        public List<Order> Orders { get; set; }


        public void OnGet() //This gets executed as soon as the page is called.
        {
            Orders = _context.Order.ToList();            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
               return Page();
            }

            _context.Order.Add(Order);
            _context.SaveChanges();

            return RedirectToPage("/Index"); // Redirect to the product list page after adding.
        }

    }
}

