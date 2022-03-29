using HomeTask1.Entities;
using HomeTask1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			List<Drinks> drinks = new List<Drinks>
			{
				new Drinks
				{
					Name="Ayran",
					Id=1
				},new Drinks
				{
					Name="Coca-Cola",
					Id=2
				},new Drinks
				{
					Name="Pepsi",
					Id=3
				},new Drinks
				{
					Name="Fanta",
					Id=4
				},new Drinks
				{
					Name="Sprite",
					Id=5
				},new Drinks
				{
					Name="Gulustan",
					Id=6
				},new Drinks
				{
					Name="Nataxtari",
					Id=7
				}
			};

			List<Hot_Meals> hotmeals = new List<Hot_Meals>
			{
				new Hot_Meals
				{
					Name="Kabab Seti",
					Id=1
				},new Hot_Meals
				{
					Name="Steyk",
					Id=2
				},new Hot_Meals
				{
					Name="Lule Kabab",
					Id=3
				},new Hot_Meals
				{
					Name="Doymece",
					Id=4
				},new Hot_Meals
				{
					Name="Antrikot",
					Id=5
				},new Hot_Meals
				{
					Name="Super Doner Eti",
					Id=6
				},new Hot_Meals
				{
					Name="El chuleta con queso",
					Id=7
				},
			};

			List<Fast_Food> fastfood = new List<Fast_Food>
			{
				new Fast_Food
				{
					Name="Hamburger",
					Id=1
				},new Fast_Food
				{
					Name="Cheeseburger",
					Id=2
				},new Fast_Food
				{
					Name="Burger",
					Id=3
				},new Fast_Food
				{
					Name="Mini Burger",
					Id=4
				},new Fast_Food
				{
					Name="Black Burger",
					Id=5
				},new Fast_Food
				{
					Name="Fried Fri",
					Id=6
				},new Fast_Food
				{
					Name="BFQ Burger",
					Id=7
				}
			};

			var model = new FoodViewModel { Drinks = drinks, Hot_Meals = hotmeals, Fast_Foods = fastfood};

			return View(model);
		}

		public IActionResult Drinks()
		{
			List<Drinks> drnks = new List<Drinks>
			{
				new Drinks
				{
					Name="Ayran",
					Id=1
				},new Drinks
				{
					Name="Coca-Cola",
					Id=2
				},new Drinks
				{
					Name="Pepsi",
					Id=3
				},new Drinks
				{
					Name="Fanta",
					Id=4
				},new Drinks
				{
					Name="Sprite",
					Id=5
				},new Drinks
				{
					Name="Gulustan",
					Id=6
				},new Drinks
				{
					Name="Nataxtari",
					Id=7
				}
			};

			return View(drnks);
		}
		public IActionResult Hot_Meals()
		{
			List<Hot_Meals> htmls = new List<Hot_Meals>
			{
				new Hot_Meals
				{
					Name="Kabab Seti",
					Id=1
				},new Hot_Meals
				{
					Name="Steyk",
					Id=2
				},new Hot_Meals
				{
					Name="Lule Kabab",
					Id=3
				},new Hot_Meals
				{
					Name="Doymece",
					Id=4
				},new Hot_Meals
				{
					Name="Antrikot",
					Id=5
				},new Hot_Meals
				{
					Name="Super Doner Eti",
					Id=6
				},new Hot_Meals
				{
					Name="El chuleta con queso",
					Id=7
				},
			};

			return View(htmls);
		}
		public IActionResult Fast_Food()
		{
			List<Fast_Food> fstfd = new List<Fast_Food>
			{
				new Fast_Food
				{
					Name="Hamburger",
					Id=1
				},new Fast_Food
				{
					Name="Cheeseburger",
					Id=2
				},new Fast_Food
				{
					Name="Burger",
					Id=3
				},new Fast_Food
				{
					Name="Mini Burger",
					Id=4
				},new Fast_Food
				{
					Name="Black Burger",
					Id=5
				},new Fast_Food
				{
					Name="Fried Fri",
					Id=6
				},new Fast_Food
				{
					Name="BFQ Burger",
					Id=7
				}
			};

			return View(fstfd);
		}
	}
}
