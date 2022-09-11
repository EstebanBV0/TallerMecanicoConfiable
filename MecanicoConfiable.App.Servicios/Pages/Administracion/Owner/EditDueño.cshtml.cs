using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class EditDueñoModel : PageModel
{
    private readonly IRepositorioDueño _repoDueño = new RepositorioDueño(new Persistencia.AppContext());

    

    private readonly ILogger<EditDueñoModel> _logger;

    public EditDueñoModel(ILogger<EditDueñoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Dueño Dueño { get; set; }
    
      public  IActionResult OnGet( int IdDueño)
        {
            Dueño = _repoDueño.GetDueñoId(IdDueño);

            if(Dueño==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Dueño  = _repoDueño.UpdateDueño(Dueño);
              if (Dueño == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListDueño"); 
        }
}
