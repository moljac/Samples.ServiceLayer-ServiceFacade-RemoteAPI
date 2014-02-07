using System.Web;
using System.Web.Optimization;

namespace HolisticWare.WebApp.MVC4RazorWebAPISignalR
{
	public partial class BundleConfig
	{
		private static void BundlesAddSignalR(BundleCollection bundles)
		{
			bundles.Add
				(
				   new StyleBundle("~/bundles/signalr-css")
						.Include
						(
						)
				);

			bundles.Add
				(
				   new ScriptBundle("~/bundles/signalr-js")
						.Include
						(
						  //"~/js/jquery.signalR-{version}.js"
						  "~/js/jquery.signalR-1.1.4.js"
						, // IE fix for console (console is used for debugging in trackerhub-client.js)
						  "~/js/console-ie-fix.max.js"
						, "~/servicelayerremoteapi/signalr/trackerhub-client.js"
						)
				);

			return;
		}

	}
}