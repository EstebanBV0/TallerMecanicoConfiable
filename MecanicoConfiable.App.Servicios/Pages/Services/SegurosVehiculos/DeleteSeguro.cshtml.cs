using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

    public class DeleteSeguroModel : PageModel

    {
    private readonly IRepositorioSeguros _repoSeguro = new RepositorioSeguros(new Persistencia.AppContext());

    private readonly ILogger<DeleteSeguroModel> _logger;

    public DeleteSeguroModel(ILogger<DeleteSeguroModel> logger)
    {
        _logger = logger;
    }

      [BindProperty]
       public Seguro Seguro { get; set; }
        public IActionResult OnGet(int IdSeguro)
        {
            Seguro = _repoSeguro.GetSegurosId(IdSeguro);
            if (Seguro == null){
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult Onpost(){
            Seguro seguroeliminado = _repoSeguro.DeleteSeguro(Seguro.IdSeguro);
              if (seguroeliminado == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListSegurosActuales");   
                   }
    }

