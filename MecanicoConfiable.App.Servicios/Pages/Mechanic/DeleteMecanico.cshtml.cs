using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

    public class DeleteMecanicoModel : PageModel

    {
    private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());

    private readonly ILogger<DeleteMecanicoModel> _logger;

    public DeleteMecanicoModel(ILogger<DeleteMecanicoModel> logger)
    {
        _logger = logger;
    }

      [BindProperty]
       public Mecanico Mecanico { get; set; }
        public IActionResult OnGet(int IdMecanico)
        {
            Mecanico = _repoMecanico.GetMecanicoId(IdMecanico);
            if (Mecanico == null){
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult Onpost(){
            Mecanico mecanicoeliminado = _repoMecanico.DeleteMedico(Mecanico.IdMecanico);
              if (mecanicoeliminado == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListMecanicos");   
                   }
    }

