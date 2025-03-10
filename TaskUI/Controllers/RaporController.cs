using Microsoft.AspNetCore.Mvc;
using StaticKimlikKarti.Models;
using TaskUI.Repostiory;

namespace TaskUI.Controllers
{
    public class RaporController : Controller
    {
        private readonly RaporYonet _raporYonet;
        List<Gorev> gorevs;
        
        public RaporController(RaporYonet raporYonet)
        {
            _raporYonet = raporYonet;
        }
        [HttpGet]
        public IActionResult Gun()
        {
            gorevs = _raporYonet.DayList();
            return View(gorevs);
        }
        [HttpGet]
        public IActionResult Hafta()
        {
            gorevs = _raporYonet.WeeklyList();
            return View(gorevs);
        }
        [HttpGet]
        public IActionResult Ay()
        {
            gorevs = _raporYonet.MonthlyList();
            return View(gorevs);
        }
    }
}
