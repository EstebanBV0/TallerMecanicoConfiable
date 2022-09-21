using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class ListCambioRepuestoModel : PageModel
{
    private static IRepositorioCambioRepuesto _repoCambioRepuesto = new RepositorioCambioRepuesto(new Persistencia.AppContext());

    private readonly ILogger<ListCambioRepuestoModel> _logger;

    public ListCambioRepuestoModel(ILogger<ListCambioRepuestoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public IEnumerable<CambioRepuesto> Cambios { get; set; }
      public  void OnGet( )
        {
         Cambios = _repoCambioRepuesto.GetAll();
        } 
}
