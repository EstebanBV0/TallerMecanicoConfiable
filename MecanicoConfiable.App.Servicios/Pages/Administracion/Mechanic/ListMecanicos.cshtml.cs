using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class ListMecanicosModel : PageModel
{
    private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());

    private readonly ILogger<ListMecanicosModel> _logger;

    public ListMecanicosModel(ILogger<ListMecanicosModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public IEnumerable<Mecanico> Mecanicos { get; set; }
      public  void OnGet( )
        {
         Mecanicos = _repoMecanico.GetAll();
        } 
}
