using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

    public class DeleteCambioRepuestoModel : PageModel

    {
    private readonly IRepositorioCambioRepuesto _repoCambioRepuesto = new RepositorioCambioRepuesto(new Persistencia.AppContext());

    private readonly ILogger<DeleteCambioRepuestoModel> _logger;

    public DeleteCambioRepuestoModel(ILogger<DeleteCambioRepuestoModel> logger)
    {
        _logger = logger;
    }

      [BindProperty]
       public CambioRepuesto CambioRepuesto { get; set; }
        public IActionResult OnGet(int IdCambioRepuesto)
        {
            CambioRepuesto = _repoCambioRepuesto.GetCambioRepuestoId(IdCambioRepuesto);
            if (CambioRepuesto == null){
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult Onpost(){
            CambioRepuesto cambiorepuestoeliminado = _repoCambioRepuesto.DeleteCambioRepuesto(CambioRepuesto.IdCambioRepuesto);
              if (cambiorepuestoeliminado == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListCambioRepuestos");   
                   }
    }

