using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class Signup : PageModel
{
    [BindProperty]
    public string FirstName { get; set; }
    [BindProperty]
    public string LastName { get; set; }
    [BindProperty]
    public string PhoneNumber { get; set; }
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Password { get; set; }
    [BindProperty]
    public string StudentNumber { get; set; }  

    public static List<(string FirstName, string LastName, string PhoneNumber, string Email, string Password, string StudentNumber)> Users = new();
    public IActionResult OnPost()
    {
        if (!string.IsNullOrWhiteSpace(FirstName) &&
            !string.IsNullOrWhiteSpace(LastName) &&
            !string.IsNullOrWhiteSpace(PhoneNumber) &&
            !string.IsNullOrWhiteSpace(Email) &&
            !string.IsNullOrWhiteSpace(Password) &&
            !string.IsNullOrWhiteSpace(StudentNumber))
        {
            Users.Add((FirstName, LastName, PhoneNumber, Email, Password, StudentNumber));
            return RedirectToPage("/Login");
        }

        return Page();
    }
}