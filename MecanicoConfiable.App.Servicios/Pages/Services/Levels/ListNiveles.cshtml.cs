using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class ListNivelesModel : PageModel
{
    private readonly IRepositorioNiveles _repoNiveles = new RepositorioNiveles(new Persistencia.AppContext());

    private readonly ILogger<ListNivelesModel> _logger;

    public ListNivelesModel(ILogger<ListNivelesModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public IEnumerable<LisFullNivels> Niveles { get; set; }
      public  void OnGet( )
        {
         Niveles = _repoNiveles.GetAll();
        } 
}
