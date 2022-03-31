using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Cola",
                    ImagePath="images/1.jpg"
                },

                 new Drink
                {
                    Id=2,
                    Name="Coffee",
                    ImagePath="images/2.jpg"
                },

                  new Drink
                {
                    Id=3,
                    Name="Su",
                    ImagePath="images/3.jpg"
                },
                   new Drink
                {
                    Id=4,
                    Name="Koktel",
                    ImagePath="images/4.jpg"
                }

            };
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id=1,
                    Name="Dolma",
                    ImagePath="images/dolma.jpg"
                },
                  new HotMeal
                {
                    Id=2,
                    Name="Kabab",
                    ImagePath="images/kabab.jpg"
                },
                    new HotMeal
                {
                    Id=3,
                    Name="Sup",
                    ImagePath="images/sup.jpg"
                },
                      new HotMeal
                {
                    Id=4,
                    Name="Julyen",
                    ImagePath="images/julyen.jpg"
                }

            };
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="Pizza",
                    ImagePath="images/pizza.jpg"
                },
                new FastFood
                {
                    Id=2,
                    Name="Burger",
                    ImagePath="images/burger.jpg"
                },
                new FastFood
                {
                    Id=3,
                    Name="Tost",
                    ImagePath="images/tost.jpg"
                },
                new FastFood
                {
                    Id=4,
                    Name="Lahmacun",
                    ImagePath="images/lahmacun.jpg"
                }
            };
            var model = new MenuListViewModel
            {
                Drinks=drinks,
                HotMeals=hotMeals,
                FastFoods=fastFoods      
            };
            return View(model);
        }

        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Cola",
                    ImagePath="images/1.png"
                },

                 new Drink
                {
                    Id=2,
                    Name="Coffee",
                    ImagePath="images/2.png"
                },

                  new Drink
                {
                    Id=3,
                    Name="Su",
                    ImagePath="images/3.png"
                },
                   new Drink
                {
                    Id=4,
                    Name="Koktel",
                    ImagePath="images/4.png"
                }

            };

            return View(drinks);
        }

        public IActionResult HotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id=1,
                    Name="Dolma",
                    ImagePath="images/dolma.png"
                },
                  new HotMeal
                {
                    Id=2,
                    Name="Kabab",
                    ImagePath="images/kabab.png"
                },
                    new HotMeal
                {
                    Id=3,
                    Name="Sup",
                    ImagePath="images/sup.jpg"
                },
                      new HotMeal
                {
                    Id=4,
                    Name="Julyen",
                    ImagePath="images/julyen.png"
                }

            };
        
            return View(hotMeals);
        }

        public IActionResult FastFood()
        {
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="Pizza",
                    ImagePath="images/pizza.jpg"
                },
                new FastFood
                {
                    Id=2,
                    Name="Burger",
                    ImagePath="images/burger.png"
                },
                new FastFood
                {
                    Id=3,
                    Name="Tost",
                    ImagePath="images/tost.png"
                },
                new FastFood
                {
                    Id=4,
                    Name="Lahmacun",
                    ImagePath="images/lahmacun.png"
                }
            };
            return View(fastFoods);

        }
    }
}
