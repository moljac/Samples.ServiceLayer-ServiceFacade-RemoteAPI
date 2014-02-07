using System.Web;
using System.Web.Mvc;

namespace HolisticWare.WebApp.MVC4RazorWebAPISignalR
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}