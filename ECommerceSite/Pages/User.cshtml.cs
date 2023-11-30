using ECommerceSite.Data;
using ECommerceSite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ECommerceSite.Pages
{
    public class UserModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ApplicationDbContext _context;

        public UserModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }
        public List<User> Users { get; set; }


        public void OnGet() //This gets executed as soon as the page is called.
        {
            Users = _context.User.ToList();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            _context.SaveChanges();

            return RedirectToPage("/Index"); // Redirect to the product list page after adding.
        }

    }
}

