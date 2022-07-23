using Microsoft.AspNetCore.Mvc;
using TestTask.Models.Intefaces;
using TestTask.Models.Entities;
using System.Threading.Tasks;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFormPostRepository _form;
        public HomeController (IFormPostRepository form)
        {
            _form = form;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OrderPost()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult OrderPost(FormPost obj)
        {
            _form.AddOrder(obj);
            return RedirectToAction("OrderPost", "Home");
        }

        public async Task<IActionResult> OrderList()
        {
            ViewBag.OrderList = await _form.GetAllOrder();
            return View();
        }
    }
}
