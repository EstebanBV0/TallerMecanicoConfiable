using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class ListAuxiliarModel : PageModel
{
    private readonly IRepositorioAuxiliar _repoAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());

    private readonly ILogger<ListAuxiliarModel> _logger;

    public ListAuxiliarModel(ILogger<ListAuxiliarModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public IEnumerable<Auxiliar> Auxiliares { get; set; }
      public  void OnGet( )
        {
         Auxiliares = _repoAuxiliar.GetAll();
        } 
}
