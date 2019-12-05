using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstagramCloneApp.DataAccess;
using InstagramCloneApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InstagramCloneApp.Pages
{
    public class RegistrationModel : PageModel
    {
        private readonly InstagramContext _context;

        public async Task<IActionResult> OnPostAsync(string login, string password)
        {
            _context.Users.Add(new User
            {
                Login = login,
                Password = password
            });
            await _context.SaveChangesAsync();
            return Redirect("");
        }
        public void OnGet()
        {

        }
    }
}