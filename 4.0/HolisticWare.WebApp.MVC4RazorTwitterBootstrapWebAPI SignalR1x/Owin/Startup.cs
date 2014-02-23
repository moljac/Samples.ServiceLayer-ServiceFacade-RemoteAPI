using Microsoft.Owin;
using Owin;

//[assembly: OwinStartup(typeof(HolisticWare.WebApp.MVC4RazorWebAPI.Owin.Startup))]
[assembly: OwinStartup(typeof(HolisticWare.WebApp.MVC4RazorWebAPI.Startup))]


//namespace HolisticWare.WebApp.MVC4RazorWebAPI.Owin
namespace HolisticWare.WebApp.MVC4RazorWebAPI
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			//Before v2
			//RouteTable.Routes.MapHubs();

			//------------------------------------------------------------------------
			// error handling
			Microsoft.AspNet.SignalR.HubConfiguration hub_configuration = null;			
			hub_configuration = new Microsoft.AspNet.SignalR.HubConfiguration();
			hub_configuration.EnableDetailedErrors = true;
			//------------------------------------------------------------------------

			//app.MapHubs();					// no logging
			app.MapHubs(hub_configuration);

			return;
		}
	}
}
/*
Error	10	
 'Owin.IAppBuilder' does not contain a definition for 'MapHubs' and no extension method 
 'MapHubs' accepting a first argument of type 'Owin.IAppBuilder' could be found 
 (are you missing a using directive or an assembly reference?)	
 \Owin\StartUp.cs

Added Attribute
 [assembly: OwinStartup(typeof(SignalRChat.Startup))]
 
	The type or namespace name 'Owin' does not exist in the namespace 'Microsoft' 
	(are you missing an assembly reference?)	
	\Owin\StartUp.cs
 

	The type or namespace name 'OwinStartup' could not be found 
	(are you missing a using directive or an assembly reference?)
	\Owin\StartUp.cs	4	12	HolisticWare.WebApp.MVC4RazorWebAPISignalR.WebMVC4RazorWebAPI

	The type or namespace name 'OwinStartupAttribute' could not be found 
	(are you missing a using directive or an assembly reference?)
	\Owin\StartUp.cs
 
 
 * Added
 *	reference Microsoft.Owin.Host.SystemWeb
 *	nuget 
 *		Install-Package Microsoft.Owin.Host.SystemWeb
 *		
 * Error
 *	'Owin.IAppBuilder' does not contain a definition for 'MapHubs' 
 *	and no extension method 'MapHubs' accepting a first argument of type 'Owin.IAppBuilder' could be found 
 *	(are you missing a using directive or an assembly reference?)	
 *	\Owin\StartUp.cs

 * 
 */


// Server Error in '/' Application.
// 
// The following errors occurred while attempting to load the app.
// - For the app startup parameter value 'MyNameSpace.Startup, MyNameSpace', 
// the assembly 'MyNameSpace' was not found.
// To disable OWIN startup discovery, add the appSetting owin:AutomaticAppStartup with a value 
// of "false" in your web.config.
// To specify the OWIN startup Assembly, Class, or Method, add the appSetting owin:AppStartup
// with the fully qualified startup class or configuration method name in your web.config.
// 
// snippet:
// 		<add key="owin:AppStartup" value="MyNameSpace.Startup, MyNameSpace" />
// changed to:
// 
// 		<add key="owin:AppStartup" value="HolisticWare.WebApp.MVC4RazorWebAPISignalR.Startup, HolisticWare.WebApp.MVC4RazorWebAPISignalR" />
// 