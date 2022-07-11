using Controle_de_Habito.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_Habito.Controllers
{
    public class HabitoController : Controller
    {
        private readonly IHabitoRepository _habitoRepository;

        public HabitoController(IHabitoRepository habitoRepository)
        {
            _habitoRepository = habitoRepository;
        }

        public IActionResult Index()
        {
            var habitos = _habitoRepository.Habitos;
            return View(habitos);
        }
    }
}
