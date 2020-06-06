using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using reCAPTCHA.AspNetCore.Attributes;

namespace reCAPTCHA.AspNetCore.Example.Pages
{
    [ValidateRecaptcha(0.5)]
    public class ContactModel : PageModel
    {
        [ViewData] public string Message { get;set; } = "Your contact page.";

        public IActionResult OnPost(ContactModel model)
        {
            if (!ModelState.IsValid) return Page();

            Message = "You contacted us";

            return Page();
        }
    }
}
