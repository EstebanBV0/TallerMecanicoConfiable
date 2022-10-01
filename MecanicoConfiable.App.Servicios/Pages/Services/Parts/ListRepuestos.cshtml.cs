using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class ListPartsModel : PageModel
{
    private readonly IRepositorioRepuestos _repoRepuestos = new RepositorioRepuestos(new Persistencia.AppContext());

    private readonly ILogger<ListPartsModel> _logger;

    public ListPartsModel(ILogger<ListPartsModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    
    public IEnumerable<Repuesto> Repuestos { get; set; }
    public string filter= null;
      public  void OnGet( string part)
        {
          filter=part;
          if(filter==null)
          {
            Repuestos = _repoRepuestos.GetAll();
          }else
          {
            Repuestos = _repoRepuestos.GetThisRep(filter);
          }
         
        } 
}
