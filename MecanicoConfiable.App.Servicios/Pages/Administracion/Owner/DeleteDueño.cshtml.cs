using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

    public class DeleteDueñoModel : PageModel

    {
    private readonly IRepositorioDueño _repoDueño = new RepositorioDueño(new Persistencia.AppContext());

    private readonly ILogger<DeleteDueñoModel> _logger;

    public DeleteDueñoModel(ILogger<DeleteDueñoModel> logger)
    {
        _logger = logger;
    }

      [BindProperty]
       public Dueño Dueño { get; set; }
        public IActionResult OnGet(int IdDueño)
        {
            Dueño = _repoDueño.GetDueñoId(IdDueño);
            if (Dueño == null){
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult Onpost(){
            Dueño dueñoeliminado = _repoDueño.DeleteDueño(Dueño.IdDueño);
              if (dueñoeliminado == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListDueño");   
                   }
    }

