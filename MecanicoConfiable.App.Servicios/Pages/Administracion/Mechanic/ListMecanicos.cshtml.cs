using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;
using Microsoft.AspNetCore.Authorization;


namespace MecanicoConfiable.App.Servicios;

[Authorize(Policy = "MustBelongADDepartment")]
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
    public string filter = null;

      public  void OnGet( string mec)
        {
          filter=mec;
          if(filter==null)
          {
            Mecanicos = _repoMecanico.GetAll();
          }else
          {
            Mecanicos = _repoMecanico.GetThisMec(filter);
          }
         
        } 
}
