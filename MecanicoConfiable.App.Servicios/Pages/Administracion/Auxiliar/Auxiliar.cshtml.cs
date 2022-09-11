using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class AuxiliarModel : PageModel
{
    private static IRepositorioAuxiliar _repoAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());

    private readonly ILogger<AuxiliarModel> _logger;

    public AuxiliarModel(ILogger<AuxiliarModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Auxiliar Auxiliar { get; set; }
      public  IActionResult OnPost( )
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Auxiliar != null) _repoAuxiliar.AddAuxiliar(Auxiliar);
            return RedirectToPage("./ListAuxiliar");
            
        } 
}
