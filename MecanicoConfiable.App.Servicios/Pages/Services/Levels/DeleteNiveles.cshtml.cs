using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

    public class DeleteNiveles : PageModel

    {
    private readonly IRepositorioNiveles _repoNiveles = new RepositorioNiveles(new Persistencia.AppContext());
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

    private readonly ILogger<DeleteNiveles> _logger;

    public DeleteNiveles(ILogger<DeleteNiveles> logger)
    {
        _logger = logger;
    }

     [BindProperty]
    public RevisionNiveles RevisionNiveles { get; set; }
    public Vehiculo Vehiculo { get; set; }

        public IActionResult OnGet(int IdNiveles)
        {
            RevisionNiveles = _repoNiveles.GetNivelesId(IdNiveles);
         Vehiculo = _repoVehiculo.GetVehiculoId(RevisionNiveles.IdVehiculo);

            if (RevisionNiveles == null){
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult Onpost(){
            RevisionNiveles NivelesEliminado = _repoNiveles.DeleteNiveles(RevisionNiveles.IdNiveles);
              if (NivelesEliminado == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListNiveles");   
                   }
    }

