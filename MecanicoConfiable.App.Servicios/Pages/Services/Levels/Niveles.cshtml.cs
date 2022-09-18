using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class NivelesModel : PageModel
{
    private static IRepositorioNiveles _reponiveles = new RepositorioNiveles(new Persistencia.AppContext());

    private readonly ILogger<NivelesModel> _logger;

    public NivelesModel(ILogger<NivelesModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public RevisionNiveles Niveles { get; set; }
      public  IActionResult OnPost( )
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("./ListNiveles");
            }
            if (Niveles != null) _reponiveles.AddNiveles(Niveles);
            return RedirectToPage("./ListNiveles");
            
        } 
}
