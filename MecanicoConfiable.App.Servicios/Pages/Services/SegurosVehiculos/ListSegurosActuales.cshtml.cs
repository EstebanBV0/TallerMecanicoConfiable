using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios.Pages
{
    public class ListSegurosActualesModel : PageModel
    {    private readonly IRepositorioSeguros _repoSeguros = new RepositorioSeguros(new Persistencia.AppContext());

    private readonly ILogger<ListSegurosActualesModel> _logger;

    public ListSegurosActualesModel(ILogger<ListSegurosActualesModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public IEnumerable<ListSegurosFull> Seguros { get; set; }
      public  void OnGet( )
        {
         Seguros = _repoSeguros.GetAll();
        } 
 }

}
