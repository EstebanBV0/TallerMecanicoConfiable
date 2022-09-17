using System.Net.Http;
using System.Net;
using System.Security.Claims;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

namespace MecanicoConfiable.App.Servicios
{
    public class LoginAdmModel : PageModel
    {
      [BindProperty]
        public Credenciales Credenciales { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(){

          if(!ModelState.IsValid){
            ModelState.AddModelError(string.Empty, "Nombre de usuario o password incorrectos");
            return Page();

          } 


          if(Credenciales.UserName =="admin" && Credenciales.Password == "123"){
          
           var claims = new List<Claim>{
                        new Claim(ClaimTypes.Name, "admin"),
                        new Claim (ClaimTypes.Email, "admin@mywebsite.com"),
                        new Claim("Department","AD"),
                        new Claim("Admin","true")
                        };
            
            var identity = new ClaimsIdentity (claims, "MyCookieAuth");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("MyCookieAuth",claimsPrincipal );
          
          return RedirectToPage("/Administracion/Administrador");
          
          }
          ModelState.AddModelError(string.Empty, "Nombre de usuario o password incorrectos");

          return Page();
          

        }
    }
}
