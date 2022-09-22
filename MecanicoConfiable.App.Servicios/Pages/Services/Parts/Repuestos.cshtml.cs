using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class RepuestoModel : PageModel
{
    private static IRepositorioRepuestos _repoRepuesto = new RepositorioRepuestos(new Persistencia.AppContext());

    private readonly ILogger<RepuestoModel> _logger;

    public RepuestoModel(ILogger<RepuestoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Repuesto Repuesto { get; set; }
      public  IActionResult OnPost( )
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Repuesto != null) _repoRepuesto.AddRepuesto(Repuesto);
            return RedirectToPage("../ServicesTec");
            
        } 
}
