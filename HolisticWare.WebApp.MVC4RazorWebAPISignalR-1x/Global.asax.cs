using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


using Microsoft.AspNet.SignalR;

namespace HolisticWare.WebApp.MVC4RazorWebAPISignalR
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class WebApiApplication : System.Web.HttpApplication
	{
		//public static BusinessLogic.Data.BusinessLogicObject BusinessLogicObject = null;

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			// not in SignalR v.2.0
			// use OWIN
			//RouteTable.Routes.MapHubs();

			//BusinessLogicObject = new BusinessLogic.Data.BusinessLogicObject();
			//
			//BusinessLogicObject.EOddsMaker.FilePath = Server.MapPath("/App_Data/xml/eoddsmaker.xml");
			//BusinessLogicObject.EOddsMaker.Import();
			//BusinessLogicObject.EOddsMaker.StartPrepareEOddMakerString();
			//
			//BusinessLogicObject.OddsAggregator.FilePath = Server.MapPath("/App_Data/xml/oddsaggregator.xml");
			//BusinessLogicObject.OddsAggregator.StartPrepareOddsAggregatorString();

			return;
		}
	}
}