using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using WebApp.Models;

namespace WebApp.Components
{
	public class CitySummary : ViewComponent
	{
		private CitiesData data;
		public CitySummary(CitiesData cdata)
		{
			data = cdata;
		}

		public IViewComponentResult Invoke(string themeName = "success")
		{
			/*return View(new CityViewModel
			{
				Cities = data.Cities.Count(),
				Population = data.Cities.Sum(c => c.Population),
			});9*/

			//return new HtmlContentViewComponentResult(
			//new HtmlString("This is a <h3><i>string</i></h3>"));

			ViewBag.Theme = themeName;
			return View(new CityViewModel
			{
				Cities = data.Cities.Count(),
				Population = data.Cities.Sum(c => c.Population)
			});

		}

		/*public string Invoke()
		{
			if (RouteData.Values["controller"] != null)
			{
				return "Controller Request";
			}
			else
			{
				return "Razor Page Request";
			}
		}*/
	}
}
