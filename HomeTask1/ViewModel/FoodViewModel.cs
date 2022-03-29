using HomeTask1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask1.ViewModel
{
	public class FoodViewModel
	{
		public List<Drinks> Drinks { get; set; }
		public List<Hot_Meals> Hot_Meals { get; set; }
		public List<Fast_Food> Fast_Foods { get; set; }
	}
}
