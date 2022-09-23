using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class EditRepuestoModel : PageModel
{
    private readonly IRepositorioRepuesto _repoRepuesto = new RepositorioRepuesto(new Persistencia.AppContext());

    

    private readonly ILogger<EditRepuestoModel> _logger;

    public EditRepuestoModel(ILogger<EditRepuestoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Repuesto Repuesto { get; set; }
    
      public  IActionResult OnGet( int IdRepuesto)
        {
            Repuesto = _repoRepuesto.GetRepuestoId(IdRepuesto);

            if(Repuesto==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Repuesto  = _repoRepuesto.UpdateRepuesto(Repuesto);
              if (Repuesto == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListRepuestos"); 
        }
}
