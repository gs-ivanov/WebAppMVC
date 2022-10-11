namespace WebAppMVC.Data
{
    using System.Collections.Generic;

    public class DbContext
    {
        public IEnumerable<Cat> AllCats()
            => new List<Cat>
            {
                new Cat{Id=1,Name="Sharo",Age=3 ,Owner=new Owner{Id=1,Name="Kenov"}},

                new Cat { Id = 2, Name = "Lady", Age = 12, Owner = new Owner { Id = 1, Name = "Kenov" } },

                new Cat { Id = 3, Name = "Sha", Age = 1, Owner = new Owner { Id = 2, Name = "Koko" } },
            };
            //return new List<Cat>
            //{
            //    new Cat{Id=1,Name="Sharo",Age=3 ,Owner=new Owner{Id=1,Name="Kenov"}},

            //    new Cat{Id=2,Name="Lady",Age=12 ,Owner=new Owner{Id=1,Name="Kenov"}},

            //    new Cat{Id=3,Name="Sha",Age=1 ,Owner=new Owner{Id=2,Name="Koko"}},
            //};
        }
}
