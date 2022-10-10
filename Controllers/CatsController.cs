namespace WebAppMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using WebAppMVC.Models;

    public class CatsController : Controller
    {
        ////Using Views
        //public IActionResult All()
        //{
        //    var cats = new List<CatViewModel>
        //    {
        //        new CatViewModel{Name="Sharo",Age=3 },
        //        new CatViewModel{Name="Lady",Age=13 }
        //    };
        //    return View(cats);
        //}

        //Using Bounding
        public IEnumerable<CatViewModel> All(string name = null)
        {
            var cats = new List<CatViewModel>
            {
                new CatViewModel{Name="Sharo",Age=3 },
                new CatViewModel{Name="Lady",Age=14 }
            };

            if (name != null)
            {
                cats = cats
                    .Where(c => c.Name.ToLower().Contains(name))
                    .ToList();
            }

            return cats;
        }

        // Using to red\turn data

        //public IEnumerable<CatViewModel> All()
        //    => new List<CatViewModel>
        //    {
        //        new CatViewModel{Name="Sharo",Age=3 },
        //        new CatViewModel{Name="Lady",Age=13 }
        //    };
    }
}
