using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class DueñoModel : PageModel
{
    private static IRepositorioDueño _repoDueño = new RepositorioDueño(new Persistencia.AppContext());

    private readonly ILogger<DueñoModel> _logger;

    public DueñoModel(ILogger<DueñoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Dueño Dueño { get; set; }
      public  IActionResult OnPost( )
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Dueño != null) _repoDueño.AddDueño(Dueño);
            return RedirectToPage("./ListDueño");
            
        } 
}
