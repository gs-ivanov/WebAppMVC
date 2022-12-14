namespace WebAppMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using WebAppMVC.Data;
    using WebAppMVC.Models;

    public class CatsController : Controller
    {

        private readonly DbContext data;

        public CatsController()
            => this.data = new DbContext();

        public IActionResult List()
        {
            var cats = this.data
                .AllCats()
                .Select(c => new CatModel
                {
                    Name = c.Name,
                    Age = c.Age,
                    Owner = c.Owner.Name
                })
                .ToList();

            if (!cats.Any())
            {
                return NotFound();
            }

            return View(cats);
        }
        public IActionResult TestTwo(int id)
        {
            return Ok(id);
        }
        public IActionResult TestOne()
        {
            return NotFound();
        }

        // new example
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CatFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Ok();
        }



        //Using Binding
        public IActionResult All(string name = null)
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

            return View(cats);
        }

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



        //Using Binding
        //public IEnumerable<CatViewModel> All(string name = null)
        //{
        //    var cats = new List<CatViewModel>
        //    {
        //        new CatViewModel{Name="Sharo",Age=3 },
        //        new CatViewModel{Name="Lady",Age=14 }
        //    };

        //    if (name != null)
        //    {
        //        cats = cats
        //            .Where(c => c.Name.ToLower().Contains(name))
        //            .ToList();
        //    }

        //    return cats;
        //}

        // Using to red\turn data

        //public IEnumerable<CatViewModel> All()
        //    => new List<CatViewModel>
        //    {
        //        new CatViewModel{Name="Sharo",Age=3 },
        //        new CatViewModel{Name="Lady",Age=13 }
        //    };
    }
}
