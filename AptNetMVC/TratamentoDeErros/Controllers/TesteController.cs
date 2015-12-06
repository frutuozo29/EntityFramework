using System.Web.Mvc;

namespace TratamentoDeErros.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult TestaErro()
        {
            try
            {
                string[] nomes = new string[] { "Renan", "Rodolffo" };
                string nome = nomes[2];
                return View();
            }
            catch (System.Exception)
            {

                return View("Error");
            }
            
        }
    }
}