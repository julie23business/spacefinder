using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpaceFinderApp.Pages
{
    public class LP : PageModel
    {
        [BindProperty]
        public string Email { get; set; } = string.Empty;
        [BindProperty]
        public string Password { get; set; } = string.Empty;
        [BindProperty]
        public bool RememberMe { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public void OnGet()
        {
           if (User.Identity != null && User.Identity.IsAuthenticated)
           {
            Response.Redirect("/Home");
           } 
        }
        
        public IActionResult OnPost()
        {
            if (Email == "test@example.com" && Password == "password123")
            {
                return RedirectToPage("/Home");
            }
            ErrorMessage = "Invalid email or password.";
            return Page();
        }

        

    }
}
