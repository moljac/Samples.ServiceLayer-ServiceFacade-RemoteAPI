using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using HolisticWare.WebApp.MVC5SignalR_2.ServiceLayer_ServiceFacade_RemoteAPIs.SignalR.Setup;

using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(Startup))]

namespace HolisticWare.WebApp.MVC5SignalR_2.ServiceLayer_ServiceFacade_RemoteAPIs.SignalR.Setup
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// Any connection or hub wire up and configuration should go here
			app.MapSignalR();
		}
	}
}