using System.Web.Mvc;
using Form.FormManager;
using System.Threading.Tasks;

namespace Form.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            var formGenerator = new FormGenerator();
            var schema = formGenerator.GenerateFormByType<Models.Form>();
            return View("Index", (object)schema.ToString());
        }
    }
}