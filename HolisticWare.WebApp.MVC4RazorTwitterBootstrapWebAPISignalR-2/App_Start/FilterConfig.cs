using System.Web;
using System.Web.Mvc;

namespace HolisticWare.WebApp.MVC4RazorTwitterBootstrapWebAPISignalR2
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}