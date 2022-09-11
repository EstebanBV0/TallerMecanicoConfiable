using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class ListDueñosModel : PageModel
{
    private readonly IRepositorioDueño _repoDueño = new RepositorioDueño(new Persistencia.AppContext());

    private readonly ILogger<ListDueñosModel> _logger;

    public ListDueñosModel(ILogger<ListDueñosModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public IEnumerable<Dueño> Dueños { get; set; }
      public  void OnGet( )
        {
         Dueños = _repoDueño.GetAll();
        } 
}
