using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

namespace MecanicoConfiable.App.Servicios
{
    public class LogOutModel : PageModel
    {
   public async Task<IActionResult> OnPostAsync()
          {

         await HttpContext.SignOutAsync("MyCookieAuth");
         return RedirectToPage("/Index");

          } 

    
        

    }
}