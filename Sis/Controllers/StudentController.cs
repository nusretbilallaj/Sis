using Microsoft.AspNetCore.Mvc;
using Sis.Data;

namespace Sis.Controllers
{
    public class StudentController : Controller
    {
        private Konteksti _konteksti;
        public StudentController(Konteksti kon)
        {
            _konteksti=kon;
        }
        public IActionResult Listo()
        {
          
           var studentet= _konteksti.Studentet.ToList();
           var komunat = _konteksti.Komunat.ToList();

            return View(studentet);
        }
    }
}
