using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace HolisticWare.WebApp.MVC5SignalR_2.ServiceLayer_ServiceFacade_RemoteAPIs.SignalR.Setup
{
	public class TrackerHub : Hub
	{
		public void Hello()
		{
			Clients.All.hello();
		}
	}
}