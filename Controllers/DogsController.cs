namespace WebAppMVC.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    public class DogsController : Controller
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
