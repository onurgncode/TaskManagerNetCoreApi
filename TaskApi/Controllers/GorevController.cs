using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StaticKimlikKarti.Models;

namespace buseferokey.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]

    
    public class GorevController : ControllerBase
    {
        private readonly AppContextDb _contextDb;

        
        public GorevController(AppContextDb contextDb)
        {
            _contextDb = contextDb;
        }


        
        [HttpGet(Name = "GetGorevler")]
        public IEnumerable<Gorev> Get()
        {
            
            var gorevListesi = _contextDb.gorev.ToList();

            
            return gorevListesi;  
            
        }
    }
}