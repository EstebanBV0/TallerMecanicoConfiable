using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

    public class DeleteRepuestoModel : PageModel

    {
    private readonly IRepositorioRepuesto _repoRepuesto = new RepositorioRepuesto(new Persistencia.AppContext());

    private readonly ILogger<DeleteRepuestoModel> _logger;

    public DeleteRepuestoModel(ILogger<DeleteRepuestoModel> logger)
    {
        _logger = logger;
    }

      [BindProperty]
       public Repuesto Repuesto { get; set; }
        public IActionResult OnGet(int IdRepuesto)
        {
            Repuesto = _repoRepuesto.GetRepuestoId(IdRepuesto);
            if (Repuesto == null){
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult Onpost(){
            Repuesto repuestoeliminado = _repoRepuesto.DeleteRepuesto(Repuesto.IdRepuesto);
              if (repuestoeliminado == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListRepuestos");   
                   }
    }

