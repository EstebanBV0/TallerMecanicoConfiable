using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class ListMechanicsModel : PageModel
{
    private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());

    private readonly ILogger<ListMechanicsModel> _logger;

    public ListMechanicsModel(ILogger<ListMechanicsModel> logger)
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
