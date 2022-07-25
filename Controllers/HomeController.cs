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

        [HttpGet]
        public IActionResult OrderPost()
        {
            ViewBag.Title = "Формирование заказа";
            return View();
        }

        [HttpPost]
        public IActionResult OrderPost(FormPost obj)
        {
            _form.AddOrder(obj);
            return RedirectToAction("OrderPost", "Home");
        }

        public async Task<IActionResult> OrderList()
        {
            ViewBag.Title = "Список заказов";
            ViewBag.OrderList = await _form.GetAllOrder();
            return View();
        }
    }
}
