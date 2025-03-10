﻿using Microsoft.AspNetCore.Mvc;
using StaticKimlikKarti.Models;
using StaticKimlikKarti.Repostiory;
using TaskUI.Repostiory;

namespace StaticKimlikKarti.Controllers
{
    public class CreateController : Controller
    {
        private readonly GorevYonet _gorevYonet;

        public CreateController(GorevYonet gorevYonet)
        {
            _gorevYonet = gorevYonet;
        }
        

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Addleme()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addleme(Gorev gorev)
        {
            var Gorevler = _gorevYonet.Add(gorev);
            return RedirectToAction("Index");
        }

        
        [HttpGet]
        public IActionResult Listele()
        {
            var listem = _gorevYonet.GetAll();
            return View(listem);
        }

        [HttpPost]
        public IActionResult Silme(int id)
        {
            _gorevYonet.Delete(id);
            return RedirectToAction("Listele");
        }
        
        [HttpPost]
        public IActionResult Tamamla(bool veri,int id)
        {
            
            _gorevYonet.Complate(veri,id);
            return RedirectToAction("Listele");
        }
        


    }
}
