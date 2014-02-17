using System.Web;
using System.Web.Optimization;

namespace HolisticWare.WebApp.MVC4RazorWebAPISignalR
{
	public partial class BundleConfig
	{
		private static void BundlesAddTwiterBootstrap(BundleCollection bundles)
		{
			bundles.Add
				(
				   new StyleBundle("~/bundles/twitter-bootstrap-css")
						.Include
						(
						  "~/css/bootstrap.css"
						//"~/css/bootstrap.max.css"
						,  "~/css/bootstrap-theme.css"
						//, "~/css/bootstrap-theme.max.css"
						, "~/css/bootstrap-footer-sticky.max.css"
						)
				);

			bundles.Add
				(
				   new ScriptBundle("~/bundles/twitter-bootstrap-js")
						.Include
						(
						  "~/js/bootstrap.js"
						//"~/js/bootstrap.max.js"
						)
				);

			return;
		}
	}
}